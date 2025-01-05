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
        private int currentUserId;
        public ManageProductsForm(int userId)
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadDropdowns();
            LoadProducts();
            currentUserId = userId;
        }

        private void ConfigureDataGridView()
        {
            listViewProducts.AutoGenerateColumns = false;
            listViewProducts.RowHeadersWidth = 15;
            listViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            listViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ProductID",
                DataPropertyName = "ProductID",
                Width = 100,
                ReadOnly = true
            });
            listViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Product Name",
                DataPropertyName = "ProductName",
                Width = 150
            });
            listViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Description",
                DataPropertyName = "ProductDescription",
                Width = 150
            });
            listViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Unit Price",
                DataPropertyName = "UnitPrice",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C" }
            });
            listViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Category",
                DataPropertyName = "Category",
                Width = 100
            });
            listViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                DataPropertyName = "QuantityInStock",
                Width = 100
            });
            listViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Supplier",
                DataPropertyName = "Supplier",
                Width = 200
            });

            listViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listViewProducts.MultiSelect = false;
            listViewProducts.ReadOnly = true;
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
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable productsTable = new DataTable();
                            adapter.Fill(productsTable);

                            listViewProducts.DataSource = productsTable;
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

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            NewSaleForm newsale = new NewSaleForm(currentUserId);
            newsale.Show();
            this.Hide();
        }
    }
}
