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
                    LoadRecentSales(conn);
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

        private void LoadRecentSales(SqlConnection conn)
        {
            try
            {
                string query = @"
            SELECT TOP 10 
                InvoiceID, 
                Cashier, 
                Customer, 
                DateRecorded, 
                Total
            FROM vw_RecentSales
            ORDER BY DateRecorded DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listViewRecentSales.Items.Clear();
                        listViewRecentSales.Columns.Clear();
                        listViewRecentSales.Columns.Add("Invoice ID", 100);
                        listViewRecentSales.Columns.Add("Cashier", 150);
                        listViewRecentSales.Columns.Add("Customer", 150);
                        listViewRecentSales.Columns.Add("Date", 150);
                        listViewRecentSales.Columns.Add("Total", 100);

                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No recent sales found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                string invoiceId = reader["InvoiceID"].ToString();
                                string cashier = reader["Cashier"].ToString();
                                string customer = reader["Customer"].ToString();
                                string dateRecorded = Convert.ToDateTime(reader["DateRecorded"]).ToString("yyyy-MM-dd");
                                string total = Convert.ToDecimal(reader["Total"]).ToString("N2");

                                ListViewItem item = new ListViewItem(invoiceId);
                                item.SubItems.Add(cashier);
                                item.SubItems.Add(customer);
                                item.SubItems.Add(dateRecorded);
                                item.SubItems.Add(total);
                                listViewRecentSales.Items.Add(item);
                            }
                        }
                    }
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
                ManageCustomersForm customers = new ManageCustomersForm();
                customers.Show();
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            if (btnSales.Enabled)
            {
                ManageSalesForm sales = new ManageSalesForm();
                sales.Show();
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (btnProducts.Enabled)
            {
                ManageProductsForm products = new ManageProductsForm();
                products.Show();
            }
        }



        private void btnReports_Click(object sender, EventArgs e)
        {
            if (btnReports.Enabled)
            {
                ReportsForm reports = new ReportsForm();
                reports.Show();
            }
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {
            if (btnDiscounts.Enabled)
            {
                ManageDiscountsForm discounts = new ManageDiscountsForm();
                discounts.Show();
            }
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            if (btnNewSale.Enabled)
            {
                NewSaleForm newsale = new NewSaleForm();
                newsale.Show();
            }
        }

        private void btnStockPurchases_Click(object sender, EventArgs e)
        {
                ManagePurchasesForm purchases = new ManagePurchasesForm();
                purchases.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
                ManageSuppliersForm suppliers = new ManageSuppliersForm();
                suppliers.Show();
        }
    }
}
