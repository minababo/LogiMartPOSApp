using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LogiMartPOSApp
{
    public partial class ManagePurchasesForm : Form
    {
        private string connectionString = "Server=.;Database=LogiMartDB;Trusted_Connection=True;";

        public ManagePurchasesForm()
        {
            InitializeComponent();
            LoadPurchases();
            LoadDropdowns();
            ConfigureListView();
        }

        private void LoadPurchases()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM vw_Purchases";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listViewPurchases.Items.Clear();

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["PurchaseID"].ToString());
                                item.SubItems.Add(reader["ProductName"].ToString());
                                item.SubItems.Add(reader["Supplier"].ToString());
                                item.SubItems.Add(reader["QuantityPurchased"].ToString());
                                item.SubItems.Add(Convert.ToDecimal(reader["PurchasePrice"]).ToString("C"));
                                item.SubItems.Add(Convert.ToDateTime(reader["PurchaseDate"]).ToShortDateString());

                                listViewPurchases.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading purchases: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadDropdowns()
        {
            try
            {
                DataTable products = GetProducts();
                if (products != null)
                {
                    cmbProduct.DataSource = products;
                    cmbProduct.DisplayMember = "ProductName";
                    cmbProduct.ValueMember = "ProductID";
                    cmbProduct.SelectedIndex = -1;
                }

                DataTable suppliers = GetSuppliers();
                if (suppliers != null)
                {
                    cmbSupplier.DataSource = suppliers;
                    cmbSupplier.DisplayMember = "CompanyName";
                    cmbSupplier.ValueMember = "SupplierID";
                    cmbSupplier.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dropdowns: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetProducts()
        {
            try
            {
                DataTable products = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ProductID, ProductName FROM PRODUCT";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(products);
                        }
                    }
                }

                return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private DataTable GetSuppliers()
        {
            try
            {
                DataTable suppliers = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SupplierID, CompanyName FROM SUPPLIER";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(suppliers);
                        }
                    }
                }

                return suppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ConfigureListView()
        {
            listViewPurchases.View = View.Details;
            listViewPurchases.FullRowSelect = true;
            listViewPurchases.GridLines = true;

            listViewPurchases.Columns.Clear();

            listViewPurchases.Columns.Add("Purchase ID", 0, HorizontalAlignment.Left);
            listViewPurchases.Columns.Add("Product Name", 200, HorizontalAlignment.Left);
            listViewPurchases.Columns.Add("Supplier", 200, HorizontalAlignment.Left);
            listViewPurchases.Columns.Add("Quantity", 200, HorizontalAlignment.Right);
            listViewPurchases.Columns.Add("Price", 190, HorizontalAlignment.Right);
            listViewPurchases.Columns.Add("Date", 120, HorizontalAlignment.Center);
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct.SelectedIndex == -1 || cmbSupplier.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtQuantityPurchased.Text) || string.IsNullOrWhiteSpace(txtPurchasePrice.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int productId = (int)cmbProduct.SelectedValue;
                int supplierId = (int)cmbSupplier.SelectedValue;
                int quantity;
                decimal purchasePrice;
                DateTime purchaseDate = dtpPurchaseDate.Value;

                if (!int.TryParse(txtQuantityPurchased.Text.Trim(), out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPurchasePrice.Text.Trim(), out purchasePrice) || purchasePrice <= 0)
                {
                    MessageBox.Show("Please enter a valid purchase price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("AddPurchase", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        cmd.Parameters.AddWithValue("@QuantityPurchased", quantity);
                        cmd.Parameters.AddWithValue("@PurchasePrice", purchasePrice);
                        cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Purchase added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPurchases();

                cmbProduct.SelectedIndex = -1;
                cmbSupplier.SelectedIndex = -1;
                txtQuantityPurchased.Clear();
                txtPurchasePrice.Clear();
                dtpPurchaseDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding purchase: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
