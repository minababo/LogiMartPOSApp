using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LogiMartPOSApp
{
    public partial class ManageDiscountsForm : Form
    {
        private string connectionString = "Server=.;Database=LogiMartDB;Trusted_Connection=True;";
        private int currentUserId;
        public ManageDiscountsForm(int userId)
        {
            InitializeComponent();
            LoadDiscounts();
            AdjustDataGridViewColumns();
            currentUserId = userId;
        }

        private void LoadDiscounts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM vw_Discounts";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable discounts = new DataTable();
                            adapter.Fill(discounts);

                            listViewDiscounts.DataSource = discounts;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading discounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDiscounts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a discount to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int discountId = Convert.ToInt32(listViewDiscounts.SelectedRows[0].Cells["DiscountID"].Value);
                decimal discountRate = nudDiscountRate.Value / 100;
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                if (startDate > endDate)
                {
                    MessageBox.Show("Start Date cannot be later than End Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("UpdateDiscount", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DiscountID", discountId);
                        cmd.Parameters.AddWithValue("@DiscountRate", discountRate);
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Discount updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDiscounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating discount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listViewDiscounts_SelectionChanged(object sender, EventArgs e)
        {
            if (listViewDiscounts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = listViewDiscounts.SelectedRows[0];
                nudDiscountRate.Value = Convert.ToDecimal(selectedRow.Cells["DiscountRate"].Value);
                dtpStartDate.Value = Convert.ToDateTime(selectedRow.Cells["StartDate"].Value);
                dtpEndDate.Value = Convert.ToDateTime(selectedRow.Cells["EndDate"].Value);
            }
        }

        private void AdjustDataGridViewColumns()
        {
            listViewDiscounts.Columns["DiscountID"].Visible = false;

            listViewDiscounts.Columns["Month"].HeaderText = "Month";
            listViewDiscounts.Columns["DiscountRate"].HeaderText = "Discount Rate (%)";
            listViewDiscounts.Columns["StartDate"].HeaderText = "Starting Date";
            listViewDiscounts.Columns["EndDate"].HeaderText = "Ending Date";

            listViewDiscounts.Columns["Month"].Width = 225;
            listViewDiscounts.Columns["DiscountRate"].Width = 225;
            listViewDiscounts.Columns["StartDate"].Width = 225;
            listViewDiscounts.Columns["EndDate"].Width = 225;

            listViewDiscounts.Columns["DiscountRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            listViewDiscounts.Columns["Month"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            listViewDiscounts.Columns["StartDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            listViewDiscounts.Columns["EndDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ManageSuppliersForm suppliers = new ManageSuppliersForm(currentUserId);
            suppliers.Show();
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
