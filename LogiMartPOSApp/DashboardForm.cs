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
                string query = @"
            SELECT P.PermissionName
            FROM ROLE_PERMISSION RP
            INNER JOIN PERMISSION P ON RP.PermissionID = P.PermissionID
            INNER JOIN [USER] U ON U.Us_RoleID = RP.RoleID
            WHERE U.UserID = @UserID";

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

                        while (reader.Read())
                        {
                            string permission = reader["PermissionName"].ToString();

                            switch (permission)
                            {
                                case "Manage Products":
                                    btnCustomers.Enabled = true;
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
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

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
                                ListViewItem item = new ListViewItem(reader["InvoiceID"].ToString());
                                item.SubItems.Add(reader["Cashier"].ToString());
                                item.SubItems.Add(reader["Customer"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["DateRecorded"]).ToString("yyyy-MM-dd"));
                                item.SubItems.Add(Convert.ToDecimal(reader["Total"]).ToString("N2"));
                                listViewRecentSales.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recent sales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.Hide();
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (btnProducts.Enabled)
            {
                ManageProductsForm products = new ManageProductsForm();
                products.Show();
                this.Hide();
            }
        }

        private void btnNewSale_MouseEnter(object sender, EventArgs e)
        {
            btnNewSale.BackColor = Color.FromArgb(115, 235, 106);
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            if (btnNewSale.Enabled)
            {
                NewSaleForm newsale = new NewSaleForm();
                newsale.Show();
                this.Hide();
            }
        }
            
        private void btnNewSale_MouseLeave(object sender, EventArgs e)
        {
            btnNewSale.BackColor = Color.FromArgb(85, 200, 85);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (btnReports.Enabled)
            {
                ReportsForm reports = new ReportsForm();
                reports.Show();
                this.Hide();
            }
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {

        }
    }
}
