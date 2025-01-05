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
    public partial class ManageSalesForm : Form
    {
        private string connectionString = "Server=.;Database=LogiMartDB;Trusted_Connection=True;Connection Timeout=30;";
        private int currentUserId;

        public ManageSalesForm(int userId)
        {
            InitializeComponent();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    LoadRecentSales(conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during initialization: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            currentUserId = userId;
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

        private void btnStockPurchases_Click(object sender, EventArgs e)
        {
            ManagePurchasesForm purchases = new ManagePurchasesForm(currentUserId);
            purchases.Show();
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
