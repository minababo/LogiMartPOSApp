using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LogiMartPOSApp
{
    public partial class ManageCustomersForm : Form
    {
        private string connectionString = "Server=.;Database=LogiMartDB;Trusted_Connection=True;Connection Timeout=30;";

        public ManageCustomersForm()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {
            listViewCustomers.Columns.Clear();
            listViewCustomers.Columns.Add("Customer ID", 100);
            listViewCustomers.Columns.Add("Customer Name", 200);
            listViewCustomers.Columns.Add("Address", 300);
            listViewCustomers.Columns.Add("Phone Number", 150);
            listViewCustomers.View = View.Details;
            listViewCustomers.FullRowSelect = true;
        }

        private void ManageCustomersForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    LoadCustomerDetails(conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCustomerDetails(SqlConnection conn)
        {
            try
            {
                string query = @"
                SELECT C.CustomerID, 
                       C.CustomerName, 
                       C.Address, 
                       CP.PhoneNumber
                FROM CUSTOMER C
                LEFT JOIN CUSTOMER_PHONE CP ON C.CustomerID = CP.CustomerID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listViewCustomers.Items.Clear();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["CustomerID"].ToString());
                            item.SubItems.Add(reader["CustomerName"].ToString());
                            item.SubItems.Add(reader["Address"].ToString());
                            item.SubItems.Add(reader["PhoneNumber"] != DBNull.Value ? reader["PhoneNumber"].ToString() : "N/A");

                            listViewCustomers.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
