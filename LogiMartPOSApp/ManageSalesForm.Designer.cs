﻿namespace LogiMartPOSApp
{
    partial class ManageSalesForm
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelUpdateDiscount = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDiscountRate = new System.Windows.Forms.NumericUpDown();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblUpdateDiscount = new System.Windows.Forms.Label();
            this.btnUpdateDiscount = new RoundedButton();
            this.lblDiscountRate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.DiscountsPanel = new System.Windows.Forms.Panel();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.listViewDiscounts = new System.Windows.Forms.DataGridView();
            this.listViewCustomers1 = new System.Windows.Forms.ListView();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnSuppliers = new RoundedButton();
            this.btnStockPurchases = new RoundedButton();
            this.btnNewSale = new RoundedButton();
            this.btnReports = new RoundedButton();
            this.btnProducts = new RoundedButton();
            this.btnCustomers = new RoundedButton();
            this.btnSales = new RoundedButton();
            this.btnDiscounts = new RoundedButton();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnLogout = new RoundedButton();
            this.panelBackground.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panelUpdateDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountRate)).BeginInit();
            this.DiscountsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewDiscounts)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
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
            this.panelBackground.TabIndex = 6;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(247)))), ((int)(((byte)(193)))));
            this.mainPanel.Controls.Add(this.panelUpdateDiscount);
            this.mainPanel.Controls.Add(this.DiscountsPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(366, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1234, 800);
            this.mainPanel.TabIndex = 3;
            // 
            // panelUpdateDiscount
            // 
            this.panelUpdateDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUpdateDiscount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUpdateDiscount.Controls.Add(this.label1);
            this.panelUpdateDiscount.Controls.Add(this.nudDiscountRate);
            this.panelUpdateDiscount.Controls.Add(this.dtpEndDate);
            this.panelUpdateDiscount.Controls.Add(this.dtpStartDate);
            this.panelUpdateDiscount.Controls.Add(this.lblUpdateDiscount);
            this.panelUpdateDiscount.Controls.Add(this.btnUpdateDiscount);
            this.panelUpdateDiscount.Controls.Add(this.lblDiscountRate);
            this.panelUpdateDiscount.Controls.Add(this.lblStartDate);
            this.panelUpdateDiscount.Controls.Add(this.lblEndDate);
            this.panelUpdateDiscount.Location = new System.Drawing.Point(528, 50);
            this.panelUpdateDiscount.Name = "panelUpdateDiscount";
            this.panelUpdateDiscount.Size = new System.Drawing.Size(656, 384);
            this.panelUpdateDiscount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "(%)";
            // 
            // nudDiscountRate
            // 
            this.nudDiscountRate.Location = new System.Drawing.Point(245, 104);
            this.nudDiscountRate.Name = "nudDiscountRate";
            this.nudDiscountRate.Size = new System.Drawing.Size(88, 39);
            this.nudDiscountRate.TabIndex = 21;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(245, 237);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpEndDate.Size = new System.Drawing.Size(350, 34);
            this.dtpEndDate.TabIndex = 20;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(245, 172);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpStartDate.Size = new System.Drawing.Size(350, 34);
            this.dtpStartDate.TabIndex = 19;
            // 
            // lblUpdateDiscount
            // 
            this.lblUpdateDiscount.AutoSize = true;
            this.lblUpdateDiscount.Font = new System.Drawing.Font("Segoe UI Historic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDiscount.Location = new System.Drawing.Point(176, 33);
            this.lblUpdateDiscount.Name = "lblUpdateDiscount";
            this.lblUpdateDiscount.Size = new System.Drawing.Size(273, 45);
            this.lblUpdateDiscount.TabIndex = 5;
            this.lblUpdateDiscount.Text = "Update Discount";
            // 
            // btnUpdateDiscount
            // 
            this.btnUpdateDiscount.BackColor = System.Drawing.Color.YellowGreen;
            this.btnUpdateDiscount.CornerRadius = 20;
            this.btnUpdateDiscount.FlatAppearance.BorderSize = 0;
            this.btnUpdateDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDiscount.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateDiscount.Location = new System.Drawing.Point(198, 307);
            this.btnUpdateDiscount.Name = "btnUpdateDiscount";
            this.btnUpdateDiscount.Size = new System.Drawing.Size(242, 48);
            this.btnUpdateDiscount.TabIndex = 3;
            this.btnUpdateDiscount.Text = "Update";
            this.btnUpdateDiscount.UseVisualStyleBackColor = false;
            // 
            // lblDiscountRate
            // 
            this.lblDiscountRate.AutoSize = true;
            this.lblDiscountRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountRate.Location = new System.Drawing.Point(46, 106);
            this.lblDiscountRate.Name = "lblDiscountRate";
            this.lblDiscountRate.Size = new System.Drawing.Size(167, 32);
            this.lblDiscountRate.TabIndex = 0;
            this.lblDiscountRate.Text = "Discount Rate:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(46, 175);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(124, 32);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(46, 240);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(116, 32);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End Date:";
            // 
            // DiscountsPanel
            // 
            this.DiscountsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountsPanel.BackColor = System.Drawing.Color.White;
            this.DiscountsPanel.Controls.Add(this.lblSalesTitle);
            this.DiscountsPanel.Controls.Add(this.listViewDiscounts);
            this.DiscountsPanel.Controls.Add(this.listViewCustomers1);
            this.DiscountsPanel.Location = new System.Drawing.Point(50, 50);
            this.DiscountsPanel.Name = "DiscountsPanel";
            this.DiscountsPanel.Size = new System.Drawing.Size(459, 725);
            this.DiscountsPanel.TabIndex = 0;
            // 
            // lblSalesTitle
            // 
            this.lblSalesTitle.AutoSize = true;
            this.lblSalesTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblSalesTitle.Location = new System.Drawing.Point(20, 10);
            this.lblSalesTitle.Name = "lblSalesTitle";
            this.lblSalesTitle.Size = new System.Drawing.Size(91, 38);
            this.lblSalesTitle.TabIndex = 0;
            this.lblSalesTitle.Text = "Sales:";
            // 
            // listViewDiscounts
            // 
            this.listViewDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDiscounts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.listViewDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listViewDiscounts.Location = new System.Drawing.Point(20, 57);
            this.listViewDiscounts.Name = "listViewDiscounts";
            this.listViewDiscounts.RowHeadersWidth = 30;
            this.listViewDiscounts.RowTemplate.Height = 28;
            this.listViewDiscounts.Size = new System.Drawing.Size(419, 650);
            this.listViewDiscounts.TabIndex = 3;
            // 
            // listViewCustomers1
            // 
            this.listViewCustomers1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCustomers1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCustomers1.HideSelection = false;
            this.listViewCustomers1.Location = new System.Drawing.Point(20, 57);
            this.listViewCustomers1.Name = "listViewCustomers1";
            this.listViewCustomers1.Size = new System.Drawing.Size(409, 650);
            this.listViewCustomers1.TabIndex = 1;
            this.listViewCustomers1.UseCompatibleStateImageBehavior = false;
            this.listViewCustomers1.View = System.Windows.Forms.View.Details;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSidebar.Controls.Add(this.btnSuppliers);
            this.panelSidebar.Controls.Add(this.btnStockPurchases);
            this.panelSidebar.Controls.Add(this.btnNewSale);
            this.panelSidebar.Controls.Add(this.btnReports);
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
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuppliers.CornerRadius = 20;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.Image = global::LogiMartPOSApp.Properties.Resources.supplier;
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.Location = new System.Drawing.Point(42, 792);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSuppliers.Size = new System.Drawing.Size(274, 61);
            this.btnSuppliers.TabIndex = 16;
            this.btnSuppliers.Text = "        Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            // 
            // btnStockPurchases
            // 
            this.btnStockPurchases.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStockPurchases.CornerRadius = 20;
            this.btnStockPurchases.FlatAppearance.BorderSize = 0;
            this.btnStockPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockPurchases.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockPurchases.Image = global::LogiMartPOSApp.Properties.Resources.stockpurchase;
            this.btnStockPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockPurchases.Location = new System.Drawing.Point(42, 691);
            this.btnStockPurchases.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnStockPurchases.Name = "btnStockPurchases";
            this.btnStockPurchases.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnStockPurchases.Size = new System.Drawing.Size(274, 61);
            this.btnStockPurchases.TabIndex = 15;
            this.btnStockPurchases.Text = "         Purchases";
            this.btnStockPurchases.UseVisualStyleBackColor = false;
            // 
            // btnNewSale
            // 
            this.btnNewSale.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNewSale.CornerRadius = 25;
            this.btnNewSale.FlatAppearance.BorderSize = 0;
            this.btnNewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSale.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSale.ForeColor = System.Drawing.Color.White;
            this.btnNewSale.Location = new System.Drawing.Point(35, 44);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(289, 102);
            this.btnNewSale.TabIndex = 8;
            this.btnNewSale.Text = "New Sale";
            this.btnNewSale.UseVisualStyleBackColor = false;
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
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(234)))), ((int)(((byte)(89)))));
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
            // 
            // ManageSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageSalesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBackground.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.panelUpdateDiscount.ResumeLayout(false);
            this.panelUpdateDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountRate)).EndInit();
            this.DiscountsPanel.ResumeLayout(false);
            this.DiscountsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewDiscounts)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panelUpdateDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDiscountRate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblUpdateDiscount;
        private RoundedButton btnUpdateDiscount;
        private System.Windows.Forms.Label lblDiscountRate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Panel DiscountsPanel;
        private System.Windows.Forms.Label lblSalesTitle;
        private System.Windows.Forms.DataGridView listViewDiscounts;
        private System.Windows.Forms.ListView listViewCustomers1;
        private System.Windows.Forms.Panel panelSidebar;
        private RoundedButton btnSuppliers;
        private RoundedButton btnStockPurchases;
        private RoundedButton btnNewSale;
        private RoundedButton btnReports;
        private RoundedButton btnProducts;
        private RoundedButton btnCustomers;
        private RoundedButton btnSales;
        private RoundedButton btnDiscounts;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblLogo;
        private RoundedButton btnLogout;
    }
}