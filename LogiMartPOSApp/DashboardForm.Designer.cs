using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogiMartPOSApp
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnReports = new RoundedButton();
            this.btnNewSale = new RoundedButton();
            this.btnProducts = new RoundedButton();
            this.btnCustomers = new RoundedButton();
            this.btnSales = new RoundedButton();
            this.btnDiscounts = new RoundedButton();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.recentSalesPanel = new System.Windows.Forms.Panel();
            this.listViewRecentSales = new System.Windows.Forms.ListView();
            this.lblRecentSalesTitle = new System.Windows.Forms.Label();
            this.announcementPanel = new System.Windows.Forms.Panel();
            this.lblAnnouncementMessage = new System.Windows.Forms.Label();
            this.lblAnnouncementTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnLogout = new RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.recentSalesPanel.SuspendLayout();
            this.announcementPanel.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnNewSale);
            this.panelSidebar.Controls.Add(this.btnProducts);
            this.panelSidebar.Controls.Add(this.btnCustomers);
            this.panelSidebar.Controls.Add(this.btnSales);
            this.panelSidebar.Controls.Add(this.btnDiscounts);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 100);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(366, 800);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReports.CornerRadius = 20;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Image = global::LogiMartPOSApp.Properties.Resources.report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(42, 590);
            this.btnReports.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnReports.Size = new System.Drawing.Size(274, 61);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "      Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnNewSale
            // 
            this.btnNewSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btnNewSale.CornerRadius = 25;
            this.btnNewSale.FlatAppearance.BorderSize = 0;
            this.btnNewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSale.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSale.ForeColor = System.Drawing.Color.White;
            this.btnNewSale.Location = new System.Drawing.Point(71, 75);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(215, 61);
            this.btnNewSale.TabIndex = 8;
            this.btnNewSale.Text = "New Sale";
            this.btnNewSale.UseVisualStyleBackColor = false;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            this.btnNewSale.MouseEnter += new System.EventHandler(this.btnNewSale_MouseEnter);
            this.btnNewSale.MouseLeave += new System.EventHandler(this.btnNewSale_MouseLeave);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProducts.CornerRadius = 20;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Image = global::LogiMartPOSApp.Properties.Resources.stock;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(42, 186);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnProducts.Size = new System.Drawing.Size(274, 61);
            this.btnProducts.TabIndex = 7;
            this.btnProducts.Text = "         Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomers.CornerRadius = 20;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(240)))), ((int)(((byte)(142)))));
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Image = global::LogiMartPOSApp.Properties.Resources.customer;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(42, 489);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCustomers.Size = new System.Drawing.Size(274, 61);
            this.btnCustomers.TabIndex = 10;
            this.btnCustomers.Text = "           Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSales.CornerRadius = 20;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Image = global::LogiMartPOSApp.Properties.Resources.sales;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(42, 287);
            this.btnSales.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSales.Size = new System.Drawing.Size(274, 61);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "   Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnDiscounts
            // 
            this.btnDiscounts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDiscounts.CornerRadius = 20;
            this.btnDiscounts.FlatAppearance.BorderSize = 0;
            this.btnDiscounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscounts.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscounts.Image = global::LogiMartPOSApp.Properties.Resources.discount;
            this.btnDiscounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscounts.Location = new System.Drawing.Point(42, 388);
            this.btnDiscounts.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnDiscounts.Name = "btnDiscounts";
            this.btnDiscounts.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnDiscounts.Size = new System.Drawing.Size(274, 61);
            this.btnDiscounts.TabIndex = 5;
            this.btnDiscounts.Text = "          Discounts";
            this.btnDiscounts.UseVisualStyleBackColor = false;
            this.btnDiscounts.Click += new System.EventHandler(this.btnDiscounts_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.panelBackground.Controls.Add(this.mainPanel);
            this.panelBackground.Controls.Add(this.panelSidebar);
            this.panelBackground.Controls.Add(this.panelTopBar);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1600, 900);
            this.panelBackground.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(247)))), ((int)(((byte)(193)))));
            this.mainPanel.Controls.Add(this.recentSalesPanel);
            this.mainPanel.Controls.Add(this.announcementPanel);
            this.mainPanel.Controls.Add(this.lblWelcome);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(366, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1234, 800);
            this.mainPanel.TabIndex = 3;
            // 
            // recentSalesPanel
            // 
            this.recentSalesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentSalesPanel.BackColor = System.Drawing.Color.White;
            this.recentSalesPanel.Controls.Add(this.listViewRecentSales);
            this.recentSalesPanel.Controls.Add(this.lblRecentSalesTitle);
            this.recentSalesPanel.Location = new System.Drawing.Point(50, 230);
            this.recentSalesPanel.Name = "recentSalesPanel";
            this.recentSalesPanel.Size = new System.Drawing.Size(1134, 486);
            this.recentSalesPanel.TabIndex = 0;
            // 
            // listViewRecentSales
            // 
            this.listViewRecentSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewRecentSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRecentSales.HideSelection = false;
            this.listViewRecentSales.Location = new System.Drawing.Point(20, 50);
            this.listViewRecentSales.Name = "listViewRecentSales";
            this.listViewRecentSales.Size = new System.Drawing.Size(1084, 413);
            this.listViewRecentSales.TabIndex = 1;
            this.listViewRecentSales.UseCompatibleStateImageBehavior = false;
            this.listViewRecentSales.View = System.Windows.Forms.View.Details;
            // 
            // lblRecentSalesTitle
            // 
            this.lblRecentSalesTitle.AutoSize = true;
            this.lblRecentSalesTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentSalesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblRecentSalesTitle.Location = new System.Drawing.Point(20, 10);
            this.lblRecentSalesTitle.Name = "lblRecentSalesTitle";
            this.lblRecentSalesTitle.Size = new System.Drawing.Size(187, 38);
            this.lblRecentSalesTitle.TabIndex = 0;
            this.lblRecentSalesTitle.Text = "Recent Sales:";
            // 
            // announcementPanel
            // 
            this.announcementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.announcementPanel.AutoSize = true;
            this.announcementPanel.BackColor = System.Drawing.Color.White;
            this.announcementPanel.Controls.Add(this.lblAnnouncementMessage);
            this.announcementPanel.Controls.Add(this.lblAnnouncementTitle);
            this.announcementPanel.Location = new System.Drawing.Point(50, 110);
            this.announcementPanel.Name = "announcementPanel";
            this.announcementPanel.Size = new System.Drawing.Size(1134, 100);
            this.announcementPanel.TabIndex = 0;
            // 
            // lblAnnouncementMessage
            // 
            this.lblAnnouncementMessage.AutoSize = true;
            this.lblAnnouncementMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncementMessage.ForeColor = System.Drawing.Color.Black;
            this.lblAnnouncementMessage.Location = new System.Drawing.Point(20, 50);
            this.lblAnnouncementMessage.Name = "lblAnnouncementMessage";
            this.lblAnnouncementMessage.Size = new System.Drawing.Size(610, 32);
            this.lblAnnouncementMessage.TabIndex = 0;
            this.lblAnnouncementMessage.Text = "System will be under maintenance on 7th January 2025.";
            // 
            // lblAnnouncementTitle
            // 
            this.lblAnnouncementTitle.AutoSize = true;
            this.lblAnnouncementTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncementTitle.ForeColor = System.Drawing.Color.Black;
            this.lblAnnouncementTitle.Location = new System.Drawing.Point(20, 10);
            this.lblAnnouncementTitle.Name = "lblAnnouncementTitle";
            this.lblAnnouncementTitle.Size = new System.Drawing.Size(227, 38);
            this.lblAnnouncementTitle.TabIndex = 1;
            this.lblAnnouncementTitle.Text = "Announcement:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(50, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(417, 48);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, [User Name]!";
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTopBar.Controls.Add(this.imgLogo);
            this.panelTopBar.Controls.Add(this.lblLogo);
            this.panelTopBar.Controls.Add(this.btnLogout);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1600, 100);
            this.panelTopBar.TabIndex = 2;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.BackgroundImage = global::LogiMartPOSApp.Properties.Resources.logo;
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Location = new System.Drawing.Point(71, 27);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(50, 50);
            this.imgLogo.TabIndex = 10;
            this.imgLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblLogo.Location = new System.Drawing.Point(127, 27);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(174, 48);
            this.lblLogo.TabIndex = 9;
            this.lblLogo.Text = "LogiMart";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::LogiMartPOSApp.Properties.Resources.Logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.CornerRadius = 20;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(1511, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 50);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(21, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelBackground);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.recentSalesPanel.ResumeLayout(false);
            this.recentSalesPanel.PerformLayout();
            this.announcementPanel.ResumeLayout(false);
            this.announcementPanel.PerformLayout();
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSidebar;
        private Panel panelTopBar;
        private RoundedButton btnCustomers;
        protected Panel panelBackground;
        private RoundedButton btnLogout;
        private PictureBox imgLogo;
        private Label lblLogo;
        private RoundedButton btnSales;
        private RoundedButton btnDiscounts;
        private RoundedButton btnProducts;
        private RoundedButton btnNewSale;
        private RoundedButton btnReports;
        private Label lblWelcome;
        private Label lblAnnouncementMessage;
        private Label lblAnnouncementTitle;
        private Label lblRecentSalesTitle;
        private ListView listViewRecentSales;
        private Panel mainPanel;
        private Panel panel1;
        private Panel announcementPanel;
        private Panel recentSalesPanel;
    }
}