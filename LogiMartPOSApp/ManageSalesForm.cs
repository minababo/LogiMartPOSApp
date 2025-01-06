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

                    LoadInvoiceData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during initialization: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            currentUserId = userId;
        }
        private void LoadInvoiceData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM vw_InvoiceDetails";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listViewSales.DataSource = dataTable;
                    foreach (DataGridViewColumn column in listViewSales.Columns)
                    {
                        column.Width = 130;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
