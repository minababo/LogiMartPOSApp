using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogiMartPOSApp
{
    public partial class NewSaleForm : Form
    {
        private string connectionString = "Server=.;Database=LogiMartDB;Trusted_Connection=True;";
        private int CurrentInvoiceId;
        private int currentUserId;

        public NewSaleForm(int userId)
        {
            InitializeComponent();
            InitializeCartGrid();

            currentUserId = userId;

            gridProducts.CellContentClick += gridProducts_CellContentClick;
            gridCart.CellContentClick += gridCart_CellContentClick;
            gridCart.CellEndEdit += gridCart_CellEndEdit;

            string cashierName = GetCashierName(currentUserId);
            CurrentInvoiceId = CreateNewInvoice(cashierName, "Customer1", currentUserId, 1, 1);
            if (CurrentInvoiceId == -1)
            {
                MessageBox.Show("Failed to create a new invoice. Please restart the process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private string GetCashierName(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT FullName FROM [USER] WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        object result = cmd.ExecuteScalar();
                        return result != null ? result.ToString() : "Unknown Cashier";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving cashier name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Unknown Cashier";
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

                    int generatedId = outputIdParam.Value != DBNull.Value ? Convert.ToInt32(outputIdParam.Value) : -1;
                    if (generatedId <= 0)
                    {
                        throw new Exception("Failed to generate a valid InvoiceID.");
                    }

                    return generatedId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating new invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
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
                            HeaderText = "",
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

        private void InitializeCartGrid()
        {
            gridCart.Columns.Clear();

            gridCart.Columns.Add("ProductID", "Product ID");
            gridCart.Columns.Add("ProductName", "Product Name");
            gridCart.Columns.Add("Quantity", "Quantity");
            gridCart.Columns.Add("UnitPrice", "Unit Price");
            gridCart.Columns.Add("TotalPrice", "Total Price");

            DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Actions",
                Text = "Remove",
                UseColumnTextForButtonValue = true,
                Name = "Remove"
            };
            gridCart.Columns.Add(removeButtonColumn);

            gridCart.Columns["Quantity"].ReadOnly = false;
        }

        private void gridCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == gridCart.Columns["Remove"].Index && e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = gridCart.Rows[e.RowIndex];
                    int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string deleteCartItemQuery = @"
                    DELETE FROM INVOICEDETAILS
                    WHERE InD_InvoiceID = @InvoiceID AND InD_ProductID = @ProductID";

                        using (SqlCommand cmd = new SqlCommand(deleteCartItemQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@InvoiceID", CurrentInvoiceId);
                            cmd.Parameters.AddWithValue("@ProductID", productId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    gridCart.Rows.Remove(selectedRow);
                    RefreshInvoiceTotals();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing item from cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            cartRow.Cells["TotalPrice"].Value = (currentQuantity + 1) * sPrice;

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

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("PlaceOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@InvoiceID", CurrentInvoiceId);

                        SqlParameter returnValue = new SqlParameter();
                        returnValue.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(returnValue);

                        cmd.ExecuteNonQuery();

                        int result = (int)returnValue.Value;

                        if (result == 0)
                        {
                            MessageBox.Show("Order has been successfully placed!", "Order Finalized", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else if (result == 50001)
                        {
                            MessageBox.Show("Invalid InvoiceID. Please check the order and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (result == 50002)
                        {
                            MessageBox.Show("Insufficient stock for one or more products.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("An unknown error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finalizing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("CancelOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@InvoiceID", CurrentInvoiceId);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order has been successfully canceled!", "Order Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error canceling order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLinkCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string phoneNumber = txtCustomerPhone.Text.Trim();
                if (string.IsNullOrEmpty(phoneNumber))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int customerId = GetCustomerIdByPhone(phoneNumber);

                if (customerId == -1)
                {
                    MessageBox.Show("No customer found for the provided phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LinkCustomerToInvoice(customerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error linking customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetCustomerIdByPhone(string phoneNumber)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
            SELECT CP.CustomerID
            FROM CUSTOMER_PHONE CP
            WHERE CP.PhoneNumber = @PhoneNumber";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving customer ID by phone: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void LinkCustomerToInvoice(int customerId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string customerName = GetCustomerNameById(conn, customerId);

                    if (string.IsNullOrEmpty(customerName))
                    {
                        lblGreeting.Text = "Customer not found.";
                        return;
                    }

                    string updateInvoiceQuery = @"
            UPDATE INVOICE
            SET Inv_CustomerID = @CustomerID
            WHERE InvoiceID = @InvoiceID";

                    using (SqlCommand cmd = new SqlCommand(updateInvoiceQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.Parameters.AddWithValue("@InvoiceID", CurrentInvoiceId);
                        cmd.ExecuteNonQuery();
                    }

                    lblGreeting.Text = $"Hello, {customerName}!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error linking customer to invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetCustomerNameById(SqlConnection conn, int customerId)
        {
            try
            {
                string query = @"
        SELECT CustomerName
        FROM CUSTOMER
        WHERE CustomerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving customer name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}