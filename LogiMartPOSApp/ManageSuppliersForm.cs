using System;
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
    public partial class ManageSuppliersForm : Form
    {
        private string connectionString = "Server=.;Database=LogiMartDB;Trusted_Connection=True;";
        private int currentUserId;

        public ManageSuppliersForm(int userId)
        {
            InitializeComponent();
            LoadSuppliers();
            currentUserId = userId;
        }

        private void LoadSuppliers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM vw_SuppliersWithProductsConcatenated";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable suppliersTable = new DataTable();
                            adapter.Fill(suppliersTable);

                            listViewSuppliers.DataSource = suppliersTable;

                            listViewSuppliers.RowHeadersWidth = 15;

                            listViewSuppliers.Columns["SupplierID"].HeaderText = "SupplierID";
                            listViewSuppliers.Columns["CompanyName"].HeaderText = "Company Name";
                            listViewSuppliers.Columns["Location"].HeaderText = "Location";
                            listViewSuppliers.Columns["ContactNumber"].HeaderText = "Contact Number";
                            listViewSuppliers.Columns["Products"].HeaderText = "Products";

                            listViewSuppliers.Columns["SupplierID"].Width = 100;
                            listViewSuppliers.Columns["CompanyName"].Width = 200;
                            listViewSuppliers.Columns["Location"].Width = 150;
                            listViewSuppliers.Columns["ContactNumber"].Width = 150;
                            listViewSuppliers.Columns["Products"].Width = 330;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCompanyName.Text) ||
                    string.IsNullOrWhiteSpace(txtLocation.Text) ||
                    string.IsNullOrWhiteSpace(txtContactNumber.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string companyName = txtCompanyName.Text.Trim();
                string location = txtLocation.Text.Trim();
                string contactNumber = txtContactNumber.Text.Trim();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("AddSupplier", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CompanyName", companyName);
                        cmd.Parameters.AddWithValue("@Location", location);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSuppliers();

                txtCompanyName.Clear();
                txtLocation.Clear();
                txtContactNumber.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnStockPurchases_Click(object sender, EventArgs e)
        {
            ManagePurchasesForm purchases = new ManagePurchasesForm(currentUserId);
            purchases.Show();
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
