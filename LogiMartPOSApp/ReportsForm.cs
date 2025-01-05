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
using System.IO;

namespace LogiMartPOSApp
{
    public partial class ReportsForm : Form
    {
        private string connectionString = "Server=.;Database=LogiMartDB;Trusted_Connection=True;Connection Timeout=30;";
        private object currentUserId;

        public ReportsForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;

            InitializeReportTypeComboBox();
            LoadReports();
        }

        private void InitializeReportTypeComboBox()
        {
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("Daily");
            cmbReportType.Items.Add("Monthly");
            cmbReportType.SelectedIndex = 0;
        }

        private void LoadReports()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            ReportID, 
                            ReportType, 
                            GeneratedDate,
                            Income,
                            Expenditure,
                            Profit,
                            [User]
                             
                        FROM REPORT 
                        ORDER BY ReportID DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable reportTable = new DataTable();
                        adapter.Fill(reportTable);
                        dataGridViewReports.DataSource = reportTable;

                        dataGridViewReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                        foreach (DataGridViewColumn column in dataGridViewReports.Columns)
                        {
                            switch (column.Name)
                            {
                                case "ReportID":
                                    column.Width = 100;
                                    break;
                                case "ReportType":
                                    column.Width = 150;
                                    break;
                                case "GeneratedDate":
                                    column.Width = 225;
                                    break;
                                case "Income":
                                case "Expenditure":
                                case "Profit":
                                    column.Width = 200;
                                    break;
                                case "User":
                                    column.Width = 250;
                                    break;
                                default:
                                    column.Width = 100;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string reportType = cmbReportType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(reportType))
            {
                MessageBox.Show("Please select a report type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string storedProcedure = reportType == "Daily"
                        ? "GenerateDailyReportWithMetrics"
                        : "GenerateMonthlyReportWithMetrics";

                    using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", currentUserId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"{reportType} report generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT TOP 1 * FROM REPORT ORDER BY GeneratedDate DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable mostRecentReport = new DataTable();
                        adapter.Fill(mostRecentReport);

                        if (mostRecentReport.Rows.Count > 0)
                        {
                            StringBuilder csvData = new StringBuilder();

                            foreach (DataColumn column in mostRecentReport.Columns)
                            {
                                csvData.Append(column.ColumnName + ",");
                            }
                            csvData.AppendLine();

                            DataRow row = mostRecentReport.Rows[0];
                            foreach (var item in row.ItemArray)
                            {
                                string formattedValue = item != null ? item.ToString().Replace(",", " ") : "";
                                csvData.Append(formattedValue + ",");
                            }
                            csvData.AppendLine();

                            SaveFileDialog saveFileDialog = new SaveFileDialog
                            {
                                Filter = "CSV Files|*.csv",
                                Title = "Save Most Recent Report as CSV"
                            };

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                File.WriteAllText(saveFileDialog.FileName, csvData.ToString());
                                MessageBox.Show("Most recent report exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No reports found to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting the most recent report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
