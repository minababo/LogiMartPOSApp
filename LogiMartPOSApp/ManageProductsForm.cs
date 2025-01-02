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
    public partial class ManageProductsForm : Form
    {
        private string connectionString = "Server=.;Database=LogiMartDB;Trusted_Connection=True;";

        public ManageProductsForm()
        {
            InitializeComponent();
            InitializeListViewColumns();
            LoadDropdowns();
            LoadProducts();
        }

        private void InitializeListViewColumns()
        {
            listViewProducts.Clear();
            listViewProducts.View = View.Details;
            listViewProducts.FullRowSelect = true;
            listViewProducts.Columns.Add("Product ID", 100, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Product Name", 150, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Description", 150, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Unit Price", 100, HorizontalAlignment.Right);
            listViewProducts.Columns.Add("Category", 100, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Quantity", 100, HorizontalAlignment.Right);
            listViewProducts.Columns.Add("Supplier", 200, HorizontalAlignment.Left);
        }

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM vw_Products";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listViewProducts.Items.Clear();

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["ProductID"].ToString());
                                item.SubItems.Add(reader["ProductName"].ToString());
                                item.SubItems.Add(reader["ProductDescription"].ToString());
                                item.SubItems.Add(Convert.ToDecimal(reader["UnitPrice"]).ToString("C"));
                                item.SubItems.Add(reader["Category"].ToString());
                                item.SubItems.Add(reader["QuantityInStock"].ToString());
                                item.SubItems.Add(reader["Supplier"] != DBNull.Value ? reader["Supplier"].ToString() : "N/A");

                                listViewProducts.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDropdowns()
        {
            try
            {
                DataTable categories = GetCategories();
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
                cmbCategory.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dropdowns: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetCategories()
        {
            DataTable categories = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT CategoryID, CategoryName FROM CATEGORY";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(categories);
                    }
                }
            }

            return categories;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                    string.IsNullOrWhiteSpace(txtProductDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                    cmbCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string productName = txtProductName.Text.Trim();
                string productDescription = txtProductDescription.Text.Trim();
                decimal unitPrice;
                if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out unitPrice) || unitPrice <= 0)
                {
                    MessageBox.Show("Please enter a valid Unit Price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int categoryID = (int)cmbCategory.SelectedValue;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("AddProduct", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@ProductDescription", productDescription);
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProducts();

                txtProductName.Clear();
                txtProductDescription.Clear();
                txtUnitPrice.Clear();
                cmbCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
