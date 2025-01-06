namespace LogiMartPOSApp
{
    partial class ManageDiscountsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDiscountsForm));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnNewSale = new RoundedButton();
            this.lblDiscountsTitle = new System.Windows.Forms.Label();
            this.listViewDiscounts = new System.Windows.Forms.DataGridView();
            this.DiscountsPanel = new System.Windows.Forms.Panel();
            this.listViewCustomers1 = new System.Windows.Forms.ListView();
            this.lblUpdateDiscount = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelUpdateDiscount = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDiscountRate = new System.Windows.Forms.NumericUpDown();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateDiscount = new RoundedButton();
            this.lblDiscountRate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.placeholderimg1 = new System.Windows.Forms.PictureBox();
            this.btnSuppliers = new RoundedButton();
            this.btnStockPurchases = new RoundedButton();
            this.btnReports = new RoundedButton();
            this.btnProducts = new RoundedButton();
            this.btnCustomers = new RoundedButton();
            this.btnSales = new RoundedButton();
            this.btnDiscounts = new RoundedButton();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new RoundedButton();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewDiscounts)).BeginInit();
            this.DiscountsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panelUpdateDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountRate)).BeginInit();
            this.panelTopBar.SuspendLayout();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeholderimg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
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
            this.panelSidebar.Size = new System.Drawing.Size(366, 1500);
            this.panelSidebar.TabIndex = 1;
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
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // lblDiscountsTitle
            // 
            this.lblDiscountsTitle.AutoSize = true;
            this.lblDiscountsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountsTitle.ForeColor = System.Drawing.Color.Black;
            this.lblDiscountsTitle.Location = new System.Drawing.Point(20, 10);
            this.lblDiscountsTitle.Name = "lblDiscountsTitle";
            this.lblDiscountsTitle.Size = new System.Drawing.Size(153, 38);
            this.lblDiscountsTitle.TabIndex = 0;
            this.lblDiscountsTitle.Text = "Discounts:";
            // 
            // listViewDiscounts
            // 
            this.listViewDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDiscounts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.listViewDiscounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listViewDiscounts.Location = new System.Drawing.Point(20, 57);
            this.listViewDiscounts.Name = "listViewDiscounts";
            this.listViewDiscounts.RowHeadersWidth = 30;
            this.listViewDiscounts.RowTemplate.Height = 28;
            this.listViewDiscounts.Size = new System.Drawing.Size(1379, 598);
            this.listViewDiscounts.TabIndex = 3;
            // 
            // DiscountsPanel
            // 
            this.DiscountsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountsPanel.BackColor = System.Drawing.Color.White;
            this.DiscountsPanel.Controls.Add(this.lblDiscountsTitle);
            this.DiscountsPanel.Controls.Add(this.listViewDiscounts);
            this.DiscountsPanel.Controls.Add(this.listViewCustomers1);
            this.DiscountsPanel.Location = new System.Drawing.Point(50, 50);
            this.DiscountsPanel.Name = "DiscountsPanel";
            this.DiscountsPanel.Size = new System.Drawing.Size(1419, 673);
            this.DiscountsPanel.TabIndex = 0;
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
            this.listViewCustomers1.Size = new System.Drawing.Size(1369, 598);
            this.listViewCustomers1.TabIndex = 1;
            this.listViewCustomers1.UseCompatibleStateImageBehavior = false;
            this.listViewCustomers1.View = System.Windows.Forms.View.Details;
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
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(247)))), ((int)(((byte)(193)))));
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.placeholderimg1);
            this.mainPanel.Controls.Add(this.panelUpdateDiscount);
            this.mainPanel.Controls.Add(this.DiscountsPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(366, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(2194, 1500);
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
            this.panelUpdateDiscount.Location = new System.Drawing.Point(1488, 50);
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
            this.btnUpdateDiscount.Click += new System.EventHandler(this.btnUpdateDiscount_Click);
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
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTopBar.Controls.Add(this.imgLogo);
            this.panelTopBar.Controls.Add(this.lblLogo);
            this.panelTopBar.Controls.Add(this.btnLogout);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(2560, 100);
            this.panelTopBar.TabIndex = 2;
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
            this.panelBackground.Size = new System.Drawing.Size(2560, 1600);
            this.panelBackground.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::LogiMartPOSApp.Properties.Resources._3;
            this.pictureBox2.Location = new System.Drawing.Point(1468, 749);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(648, 734);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::LogiMartPOSApp.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(764, 749);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 734);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // placeholderimg1
            // 
            this.placeholderimg1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.placeholderimg1.Image = global::LogiMartPOSApp.Properties.Resources._1;
            this.placeholderimg1.Location = new System.Drawing.Point(50, 749);
            this.placeholderimg1.Name = "placeholderimg1";
            this.placeholderimg1.Size = new System.Drawing.Size(648, 734);
            this.placeholderimg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.placeholderimg1.TabIndex = 1;
            this.placeholderimg1.TabStop = false;
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
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
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
            this.btnStockPurchases.Click += new System.EventHandler(this.btnStockPurchases_Click);
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
            this.btnDiscounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(234)))), ((int)(((byte)(89)))));
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
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::LogiMartPOSApp.Properties.Resources.Logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.CornerRadius = 20;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(2471, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 50);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ManageDiscountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2560, 1600);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageDiscountsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageDiscountsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listViewDiscounts)).EndInit();
            this.DiscountsPanel.ResumeLayout(false);
            this.DiscountsPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panelUpdateDiscount.ResumeLayout(false);
            this.panelUpdateDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountRate)).EndInit();
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeholderimg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton btnSuppliers;
        private RoundedButton btnStockPurchases;
        private RoundedButton btnNewSale;
        private RoundedButton btnReports;
        private RoundedButton btnProducts;
        private RoundedButton btnCustomers;
        private RoundedButton btnDiscounts;
        private System.Windows.Forms.Panel panelSidebar;
        private RoundedButton btnSales;
        private System.Windows.Forms.Label lblDiscountsTitle;
        private System.Windows.Forms.DataGridView listViewDiscounts;
        private System.Windows.Forms.Panel DiscountsPanel;
        private System.Windows.Forms.ListView listViewCustomers1;
        private System.Windows.Forms.Label lblUpdateDiscount;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panelUpdateDiscount;
        private RoundedButton btnUpdateDiscount;
        private System.Windows.Forms.Label lblDiscountRate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.PictureBox imgLogo;
        private RoundedButton btnLogout;
        protected System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.NumericUpDown nudDiscountRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox placeholderimg1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}