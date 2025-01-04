namespace LogiMartPOSApp
{
    partial class ReportsForm
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
            this.btnAddProduct = new RoundedButton();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddProduct.CornerRadius = 20;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddProduct.Image = global::LogiMartPOSApp.Properties.Resources.right_arrow;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.Location = new System.Drawing.Point(279, 202);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddProduct.Size = new System.Drawing.Size(242, 47);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Add to Cart";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddProduct);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton btnAddProduct;
    }
}