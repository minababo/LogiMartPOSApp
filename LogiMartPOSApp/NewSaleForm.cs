﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogiMartPOSApp
{
    public partial class NewSaleForm : Form
    {
        private string connectionString = "Server=.;Database=LogiMartDB;Trusted_Connection=True;";
        private int CurrentInvoiceId;

        public NewSaleForm()
        {
            InitializeComponent();
            InitializeCartGrid();


            gridProducts.CellContentClick += gridProducts_CellContentClick;
            gridCart.CellEndEdit += gridCart_CellEndEdit;

            LoadCustomers();
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;

            CurrentInvoiceId = CreateNewInvoice("Cashier1", "Customer1", 1, 1, 1);
            if (CurrentInvoiceId == -1)
            {
                MessageBox.Show("Failed to create a new invoice. Please restart the process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadProducts(string storedProcedure, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    gridProducts.DataSource = dt;

                    foreach (DataGridViewColumn column in gridProducts.Columns)
                    {
                        column.Width = 139;
                    }

                    if (!gridProducts.Columns.Contains("Add"))
                    {
                        DataGridViewButtonColumn addButtonColumn = new DataGridViewButtonColumn
                        {
                            HeaderText = "Add",
                            Text = "Add",
                            UseColumnTextForButtonValue = true,
                            Name = "Add"
                        };
                        gridProducts.Columns.Add(addButtonColumn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CustomerID, CustomerName FROM CUSTOMER ORDER BY CustomerName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbCustomer.Items.Clear();
                            Dictionary<int, string> customers = new Dictionary<int, string>();

                            while (reader.Read())
                            {
                                int customerId = Convert.ToInt32(reader["CustomerID"]);
                                string customerName = reader["CustomerName"].ToString();

                                customers.Add(customerId, customerName);
                                cmbCustomer.Items.Add(customerName);
                            }

                            cmbCustomer.Tag = customers;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem != null && cmbCustomer.Tag != null)
            {
                var customers = (Dictionary<int, string>)cmbCustomer.Tag;
                string selectedCustomerName = cmbCustomer.SelectedItem.ToString();

                int selectedCustomerId = customers.FirstOrDefault(c => c.Value == selectedCustomerName).Key;

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE INVOICE SET Inv_CustomerID = @CustomerID WHERE InvoiceID = @InvoiceID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerId);
                            cmd.Parameters.AddWithValue("@InvoiceID", CurrentInvoiceId);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    RefreshInvoiceTotals();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private int CreateNewInvoice(string cashierName, string customer, int userId, int customerId, int discountId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("CreateNewInvoice", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@CashierName", cashierName);
                    cmd.Parameters.AddWithValue("@Customer", customer);
                    cmd.Parameters.AddWithValue("@Inv_UserID", userId);
                    cmd.Parameters.AddWithValue("@Inv_CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@Inv_DiscountID", discountId);

                    SqlParameter outputIdParam = new SqlParameter("@InvoiceID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);

                    cmd.ExecuteNonQuery();

                    return (int)outputIdParam.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating new invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void AddInvoiceDetail(string productName, int quantity, decimal sPrice, int invoiceId, int productId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("AddInvoiceDetail", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@Product", productName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@SPrice", sPrice);
                    cmd.Parameters.AddWithValue("@InD_InvoiceID", invoiceId);
                    cmd.Parameters.AddWithValue("@InD_ProductID", productId);

                    cmd.ExecuteNonQuery();
                }
                RefreshInvoiceTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product to invoice details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == gridProducts.Columns["Add"].Index && e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = gridProducts.Rows[e.RowIndex];

                    string productName = selectedRow.Cells["ProductName"].Value.ToString();
                    decimal sPrice = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                    int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

                    bool productExists = false;

                    foreach (DataGridViewRow cartRow in gridCart.Rows)
                    {
                        if (Convert.ToInt32(cartRow.Cells["ProductID"].Value) == productId)
                        {
                            int currentQuantity = Convert.ToInt32(cartRow.Cells["Quantity"].Value);
                            cartRow.Cells["Quantity"].Value = currentQuantity + 1;
                            cartRow.Cells["TotalPrice"].Value = (currentQuantity + 1) * sPrice;

                            UpdateInvoiceDetailQuantity(productId, currentQuantity + 1);
                            RefreshInvoiceTotals();
                            productExists = true;
                            break;
                        }
                    }

                    if (!productExists)
                    {
                        gridCart.Rows.Add(productId, productName, 1, sPrice, sPrice);
                        AddInvoiceDetail(productName, 1, sPrice, CurrentInvoiceId, productId);
                    }

                    RefreshInvoiceTotals();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product to cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInvoiceDetailQuantity(int productId, int newQuantity)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
            UPDATE INVOICEDETAILS
            SET Quantity = @Quantity, FinalPrice = Quantity * SPrice
            WHERE InD_InvoiceID = @InvoiceID AND InD_ProductID = @ProductID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Quantity", newQuantity);
                        cmd.Parameters.AddWithValue("@InvoiceID", CurrentInvoiceId);
                        cmd.Parameters.AddWithValue("@ProductID", productId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating invoice detail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void InitializeCartGrid()
        {
            gridCart.Columns.Clear();

            gridCart.Columns.Add("ProductID", "Product ID");
            gridCart.Columns.Add("ProductName", "Product Name");
            gridCart.Columns.Add("Quantity", "Quantity");
            gridCart.Columns.Add("UnitPrice", "Unit Price");
            gridCart.Columns.Add("TotalPrice", "Total Price");

            gridCart.Columns["Quantity"].ReadOnly = false;
        }


        private async void gridCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == gridCart.Columns["Quantity"].Index)
                {
                    DataGridViewRow row = gridCart.Rows[e.RowIndex];

                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                    int productId = Convert.ToInt32(row.Cells["ProductID"].Value);


                    row.Cells["TotalPrice"].Value = quantity * unitPrice;

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = @"
                UPDATE INVOICEDETAILS
                SET Quantity = @Quantity, FinalPrice = @FinalPrice
                WHERE InD_InvoiceID = @InvoiceID AND InD_ProductID = @ProductID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@FinalPrice", quantity * unitPrice);
                            cmd.Parameters.AddWithValue("@InvoiceID", CurrentInvoiceId);
                            cmd.Parameters.AddWithValue("@ProductID", productId);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    await Task.Delay(100);
                    RefreshInvoiceTotals();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchProduct.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                SqlParameter[] parameters = { new SqlParameter("@SearchTerm", searchTerm) };
                LoadProducts("SearchProductsByName", parameters);
            }
            else
            {
                gridProducts.DataSource = null;
            }
        }

        private void RefreshInvoiceTotals()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT SubTotal, TotalDiscount, TotalAmount
                FROM INVOICE
                WHERE InvoiceID = @InvoiceID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceID", CurrentInvoiceId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblSubtotal.Text = $"Subtotal: {reader["SubTotal"]:C2}";
                                lblDiscount.Text = $"Discount: {reader["TotalDiscount"]:C2}";
                                lblTotal.Text = $"Total: {reader["TotalAmount"]:C2}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing invoice totals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCategory1_Click(object sender, EventArgs e)
        {
            int categoryId = 1;
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };
            LoadProducts("GetProductsByCategory", parameters);
        }

        private void btnCategory2_Click(object sender, EventArgs e)
        {
            int categoryId = 2;
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };
            LoadProducts("GetProductsByCategory", parameters);
        }

        private void btnCategory3_Click(object sender, EventArgs e)
        {
            int categoryId = 3;
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };
            LoadProducts("GetProductsByCategory", parameters);
        }

        private void btnCategory4_Click(object sender, EventArgs e)
        {
            int categoryId = 4;
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };
            LoadProducts("GetProductsByCategory", parameters);
        }

        private void btnCategory5_Click(object sender, EventArgs e)
        {
            int categoryId = 5;
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };
            LoadProducts("GetProductsByCategory", parameters);
        }

        private void btnCategory6_Click(object sender, EventArgs e)
        {
            int categoryId = 6;
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };
            LoadProducts("GetProductsByCategory", parameters);
        }

        private void btnCategory7_Click(object sender, EventArgs e)
        {
            int categoryId = 7;
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };
            LoadProducts("GetProductsByCategory", parameters);
        }

        private void btnCategory8_Click(object sender, EventArgs e)
        {
            int categoryId = 8;
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };
            LoadProducts("GetProductsByCategory", parameters);
        }

        private void btnCategory9_Click(object sender, EventArgs e)
        {
            int categoryId = 9;
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };
            LoadProducts("GetProductsByCategory", parameters);
        }

        private void roundedButton10_Click(object sender, EventArgs e)
        {
            int categoryId = 10;
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };
            LoadProducts("GetProductsByCategory", parameters);
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchProduct.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                SqlParameter[] parameters = { new SqlParameter("@SearchTerm", searchTerm) };
                LoadProducts("SearchProductsByName", parameters);
            }
            else
            {
                MessageBox.Show("Please enter a product name to search.");
            }
        }

    }
}
