﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LogiMartPOSApp
{
    public partial class ManagePurchasesForm : Form
    {
        private string connectionString = "Server=.;Database=LogiMartDB;Trusted_Connection=True;";
        private int currentUserId;

        public ManagePurchasesForm(int userId)
        {
            InitializeComponent();
            LoadPurchases();
            LoadDropdowns();
            currentUserId = userId;
        }

        private void LoadPurchases()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM vw_Purchases";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable purchases = new DataTable();
                            adapter.Fill(purchases);
                            listViewPurchases.DataSource = purchases;
                        }
                    }
                }
                listViewPurchases.RowHeadersWidth = 15;
                if (listViewPurchases.Columns.Count > 0)
                {
                    listViewPurchases.Columns[0].Width = 100;
                    listViewPurchases.Columns[1].Width = 150;
                    listViewPurchases.Columns[2].Width = 200;
                    listViewPurchases.Columns[3].Width = 150;
                    listViewPurchases.Columns[4].Width = 150;
                    listViewPurchases.Columns[5].Width = 200;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading purchases: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadDropdowns()
        {
            try
            {
                DataTable products = GetProducts();
                if (products != null)
                {
                    cmbProduct.DataSource = products;
                    cmbProduct.DisplayMember = "ProductName";
                    cmbProduct.ValueMember = "ProductID";
                    cmbProduct.SelectedIndex = -1;
                }

                DataTable suppliers = GetSuppliers();
                if (suppliers != null)
                {
                    cmbSupplier.DataSource = suppliers;
                    cmbSupplier.DisplayMember = "CompanyName";
                    cmbSupplier.ValueMember = "SupplierID";
                    cmbSupplier.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dropdowns: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetProducts()
        {
            try
            {
                DataTable products = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ProductID, ProductName FROM PRODUCT";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(products);
                        }
                    }
                }

                return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private DataTable GetSuppliers()
        {
            try
            {
                DataTable suppliers = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SupplierID, CompanyName FROM SUPPLIER";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(suppliers);
                        }
                    }
                }

                return suppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct.SelectedIndex == -1 || cmbSupplier.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtQuantityPurchased.Text) || string.IsNullOrWhiteSpace(txtPurchasePrice.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int productId = (int)cmbProduct.SelectedValue;
                int supplierId = (int)cmbSupplier.SelectedValue;
                int quantity;
                decimal purchasePrice;
                DateTime purchaseDate = dtpPurchaseDate.Value;

                if (!int.TryParse(txtQuantityPurchased.Text.Trim(), out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPurchasePrice.Text.Trim(), out purchasePrice) || purchasePrice <= 0)
                {
                    MessageBox.Show("Please enter a valid purchase price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("AddPurchase", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        cmd.Parameters.AddWithValue("@QuantityPurchased", quantity);
                        cmd.Parameters.AddWithValue("@PurchasePrice", purchasePrice);
                        cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Purchase added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPurchases();

                cmbProduct.SelectedIndex = -1;
                cmbSupplier.SelectedIndex = -1;
                txtQuantityPurchased.Clear();
                txtPurchasePrice.Clear();
                dtpPurchaseDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding purchase: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            NewSaleForm newsale = new NewSaleForm(currentUserId);
            newsale.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ManageProductsForm products = new ManageProductsForm(currentUserId);
            products.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ManageSalesForm sales = new ManageSalesForm(currentUserId);
            sales.Show();
            this.Hide();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ManageSuppliersForm suppliers = new ManageSuppliersForm(currentUserId);
            suppliers.Show();
            this.Hide();
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {
            ManageDiscountsForm discounts = new ManageDiscountsForm(currentUserId);
            discounts.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ManageCustomersForm customers = new ManageCustomersForm(currentUserId);
            customers.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm(currentUserId);
            reports.Show();
            this.Hide();
        }
    }
}
