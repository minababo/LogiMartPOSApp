using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogiMartPOSApp
{
    public partial class DashboardForm : Form
    {
        private string connectionString = "Server=.;Database=LogiMartDB;Trusted_Connection=True;Connection Timeout=30;";
        private int currentUserId;

        public DashboardForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    ApplyRolePermissions(conn);
                    LoadWelcomeMessage(conn);
                    LoadRecentSalesToGrid(conn);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during initialization: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ApplyRolePermissions(SqlConnection conn)
        {
            try
            {
                string query = "SELECT PermissionName FROM GetUserPermissions(@UserID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        btnCustomers.Enabled = false;
                        btnProducts.Enabled = false;
                        btnSales.Enabled = false;
                        btnNewSale.Enabled = false;
                        btnReports.Enabled = false;
                        btnStockPurchases.Enabled = false;
                        btnSuppliers.Enabled = false;
                        btnDiscounts.Enabled = false;

                        while (reader.Read())
                        {
                            string permission = reader["PermissionName"].ToString();

                            switch (permission)
                            {
                                case "Manage Products":
                                    btnProducts.Enabled = true;
                                    break;

                                case "View Sales":
                                    btnSales.Enabled = true;
                                    break;

                                case "Generate Sales":
                                    btnNewSale.Enabled = true;
                                    break;

                                case "Generate Reports":
                                    btnReports.Enabled = true;
                                    break;

                                case "Manage Users":
                                    btnCustomers.Enabled = true;
                                    break;

                                case "Manage Stock":
                                    btnStockPurchases.Enabled = true;
                                    btnSuppliers.Enabled = true;
                                    break;

                                case "Manage Discounts":
                                    btnDiscounts.Enabled = true;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying permissions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadWelcomeMessage(SqlConnection conn)
        {
            try
            {
                string query = "SELECT FullName FROM [USER] WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUserId);

                    object result = cmd.ExecuteScalar();
                    string fullName = result != null ? result.ToString() : "User";

                    lblWelcome.Text = $"Welcome, {fullName}!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading welcome message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRecentSalesToGrid(SqlConnection conn)
        {
            try
            {
                string query = "SELECT * FROM vw_RecentSales";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridViewRecentSales.DataSource = dataTable;

                    dataGridViewRecentSales.Columns["InvoiceID"].Width = 100;
                    dataGridViewRecentSales.Columns["Cashier"].Width = 150;
                    dataGridViewRecentSales.Columns["Customer"].Width = 150;
                    dataGridViewRecentSales.Columns["SubTotal"].Width = 100;
                    dataGridViewRecentSales.Columns["TotalDiscount"].Width = 100;
                    dataGridViewRecentSales.Columns["TotalAmount"].Width = 100;
                    dataGridViewRecentSales.Columns["DateRecorded"].Width = 150;

                    dataGridViewRecentSales.Columns["DateRecorded"].DefaultCellStyle.Format = "yyyy-MM-dd";
                    dataGridViewRecentSales.Columns["SubTotal"].DefaultCellStyle.Format = "N2";
                    dataGridViewRecentSales.Columns["TotalDiscount"].DefaultCellStyle.Format = "N2";
                    dataGridViewRecentSales.Columns["TotalAmount"].DefaultCellStyle.Format = "N2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading recent sales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (btnCustomers.Enabled)
            {
                ManageCustomersForm customers = new ManageCustomersForm(currentUserId);
                customers.Show();
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            if (btnSales.Enabled)
            {
                ManageSalesForm sales = new ManageSalesForm(currentUserId);
                sales.Show();
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (btnProducts.Enabled)
            {
                ManageProductsForm products = new ManageProductsForm(currentUserId);
                products.Show();
            }
        }



        private void btnReports_Click(object sender, EventArgs e)
        {
            if (btnReports.Enabled)
            {
                ReportsForm reports = new ReportsForm(currentUserId);
                reports.Show();
            }
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {
            if (btnDiscounts.Enabled)
            {
                ManageDiscountsForm discounts = new ManageDiscountsForm(currentUserId);
                discounts.Show();
            }
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            if (btnNewSale.Enabled)
            {
                NewSaleForm newsale = new NewSaleForm(currentUserId);
                newsale.Show();
            }
        }

        private void btnStockPurchases_Click(object sender, EventArgs e)
        {
                ManagePurchasesForm purchases = new ManagePurchasesForm(currentUserId);
                purchases.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
                ManageSuppliersForm suppliers = new ManageSuppliersForm(currentUserId);
                suppliers.Show();
        }
    }
}
