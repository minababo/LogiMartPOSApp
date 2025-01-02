using System.Windows.Forms;

namespace LogiMartPOSApp
{
    partial class ManageProductsForm
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
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.lblNewProduct = new System.Windows.Forms.Label();
            this.panelAddProduct = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.btnAddProduct = new RoundedButton();
            this.btnReports = new RoundedButton();
            this.btnNewSale = new RoundedButton();
            this.btnProducts = new RoundedButton();
            this.btnCustomers = new RoundedButton();
            this.btnSales = new RoundedButton();
            this.btnDiscounts = new RoundedButton();
            this.btnLogout = new RoundedButton();
            this.panelSidebar.SuspendLayout();
            this.productsPanel.SuspendLayout();
            this.panelAddProduct.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panelTopBar.SuspendLayout();
            this.panelBackground.SuspendLayout();
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
            // lblProductsTitle
            // 
            this.lblProductsTitle.AutoSize = true;
            this.lblProductsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsTitle.ForeColor = System.Drawing.Color.Black;
            this.lblProductsTitle.Location = new System.Drawing.Point(20, 10);
            this.lblProductsTitle.Name = "lblProductsTitle";
            this.lblProductsTitle.Size = new System.Drawing.Size(140, 38);
            this.lblProductsTitle.TabIndex = 0;
            this.lblProductsTitle.Text = "Products:";
            // 
            // productsPanel
            // 
            this.productsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsPanel.BackColor = System.Drawing.Color.White;
            this.productsPanel.Controls.Add(this.listViewProducts);
            this.productsPanel.Controls.Add(this.lblProductsTitle);
            this.productsPanel.Location = new System.Drawing.Point(50, 50);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(459, 725);
            this.productsPanel.TabIndex = 0;
            // 
            // listViewProducts
            // 
            this.listViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(20, 57);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(409, 650);
            this.listViewProducts.TabIndex = 1;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // lblNewProduct
            // 
            this.lblNewProduct.AutoSize = true;
            this.lblNewProduct.Font = new System.Drawing.Font("Segoe UI Historic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProduct.Location = new System.Drawing.Point(212, 33);
            this.lblNewProduct.Name = "lblNewProduct";
            this.lblNewProduct.Size = new System.Drawing.Size(215, 45);
            this.lblNewProduct.TabIndex = 5;
            this.lblNewProduct.Text = "New Product";
            // 
            // panelAddProduct
            // 
            this.panelAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAddProduct.Controls.Add(this.lblCategory);
            this.panelAddProduct.Controls.Add(this.cmbCategory);
            this.panelAddProduct.Controls.Add(this.lblNewProduct);
            this.panelAddProduct.Controls.Add(this.txtProductName);
            this.panelAddProduct.Controls.Add(this.txtProductDescription);
            this.panelAddProduct.Controls.Add(this.txtUnitPrice);
            this.panelAddProduct.Controls.Add(this.btnAddProduct);
            this.panelAddProduct.Controls.Add(this.lblProductName);
            this.panelAddProduct.Controls.Add(this.lblProductDescription);
            this.panelAddProduct.Controls.Add(this.lblUnitPrice);
            this.panelAddProduct.Location = new System.Drawing.Point(528, 50);
            this.panelAddProduct.Name = "panelAddProduct";
            this.panelAddProduct.Size = new System.Drawing.Size(656, 458);
            this.panelAddProduct.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(46, 303);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(115, 32);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.DropDownWidth = 200;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(245, 303);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(350, 40);
            this.cmbCategory.TabIndex = 11;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(245, 104);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(350, 39);
            this.txtProductName.TabIndex = 7;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDescription.Location = new System.Drawing.Point(245, 172);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(350, 39);
            this.txtProductDescription.TabIndex = 8;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(245, 237);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(350, 39);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(46, 108);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(172, 32);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.Location = new System.Drawing.Point(46, 175);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(140, 32);
            this.lblProductDescription.TabIndex = 2;
            this.lblProductDescription.Text = "Description:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(46, 240);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(121, 32);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(247)))), ((int)(((byte)(193)))));
            this.mainPanel.Controls.Add(this.panelAddProduct);
            this.mainPanel.Controls.Add(this.productsPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(366, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1234, 800);
            this.mainPanel.TabIndex = 3;
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
            this.panelBackground.TabIndex = 5;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddProduct.CornerRadius = 20;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddProduct.Location = new System.Drawing.Point(198, 385);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(242, 47);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
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
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "      Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnNewSale
            // 
            this.btnNewSale.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewSale.CornerRadius = 25;
            this.btnNewSale.FlatAppearance.BorderSize = 0;
            this.btnNewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSale.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSale.ForeColor = System.Drawing.Color.White;
            this.btnNewSale.Location = new System.Drawing.Point(42, 44);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(289, 102);
            this.btnNewSale.TabIndex = 1;
            this.btnNewSale.Text = "New Sale";
            this.btnNewSale.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(234)))), ((int)(((byte)(89)))));
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
            this.btnProducts.TabIndex = 2;
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
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "           Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
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
            this.btnSales.TabIndex = 3;
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
            this.btnDiscounts.TabIndex = 4;
            this.btnDiscounts.Text = "          Discounts";
            this.btnDiscounts.UseVisualStyleBackColor = false;
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
            this.btnLogout.TabIndex = 13;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ManageProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProductsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            this.panelAddProduct.ResumeLayout(false);
            this.panelAddProduct.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton btnReports;
        private RoundedButton btnNewSale;
        private RoundedButton btnProducts;
        private RoundedButton btnCustomers;
        private RoundedButton btnDiscounts;
        private System.Windows.Forms.Panel panelSidebar;
        private RoundedButton btnSales;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.Label lblNewProduct;
        private System.Windows.Forms.Panel panelAddProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private RoundedButton btnAddProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelTopBar;
        private RoundedButton btnLogout;
        protected System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}