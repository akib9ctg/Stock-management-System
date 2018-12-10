namespace StockManagementSystemApp.UI
{
    partial class StockManagementUI
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
            this.setupCategorybutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewSalesTwoDatesbutton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.stockOutbutton = new System.Windows.Forms.Button();
            this.stockInbutton = new System.Windows.Forms.Button();
            this.setupItembutton = new System.Windows.Forms.Button();
            this.setupCompanybutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setupCategorybutton
            // 
            this.setupCategorybutton.Location = new System.Drawing.Point(30, 28);
            this.setupCategorybutton.Name = "setupCategorybutton";
            this.setupCategorybutton.Size = new System.Drawing.Size(92, 23);
            this.setupCategorybutton.TabIndex = 0;
            this.setupCategorybutton.Text = "Setup Category";
            this.setupCategorybutton.UseVisualStyleBackColor = true;
            this.setupCategorybutton.Click += new System.EventHandler(this.setupCategorybutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewSalesTwoDatesbutton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.stockOutbutton);
            this.groupBox1.Controls.Add(this.stockInbutton);
            this.groupBox1.Controls.Add(this.setupItembutton);
            this.groupBox1.Controls.Add(this.setupCompanybutton);
            this.groupBox1.Controls.Add(this.setupCategorybutton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Management";
            // 
            // viewSalesTwoDatesbutton
            // 
            this.viewSalesTwoDatesbutton.Location = new System.Drawing.Point(30, 214);
            this.viewSalesTwoDatesbutton.Name = "viewSalesTwoDatesbutton";
            this.viewSalesTwoDatesbutton.Size = new System.Drawing.Size(92, 53);
            this.viewSalesTwoDatesbutton.TabIndex = 0;
            this.viewSalesTwoDatesbutton.Text = "View Sales Betweeen Two Dates";
            this.viewSalesTwoDatesbutton.UseVisualStyleBackColor = true;
            this.viewSalesTwoDatesbutton.Click += new System.EventHandler(this.viewSalesTwoDatesbutton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(30, 173);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 35);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search and View Items";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // stockOutbutton
            // 
            this.stockOutbutton.Location = new System.Drawing.Point(30, 144);
            this.stockOutbutton.Name = "stockOutbutton";
            this.stockOutbutton.Size = new System.Drawing.Size(92, 23);
            this.stockOutbutton.TabIndex = 0;
            this.stockOutbutton.Text = "Stock Out";
            this.stockOutbutton.UseVisualStyleBackColor = true;
            this.stockOutbutton.Click += new System.EventHandler(this.stockOutbutton_Click);
            // 
            // stockInbutton
            // 
            this.stockInbutton.Location = new System.Drawing.Point(30, 115);
            this.stockInbutton.Name = "stockInbutton";
            this.stockInbutton.Size = new System.Drawing.Size(92, 23);
            this.stockInbutton.TabIndex = 0;
            this.stockInbutton.Text = "Stock In";
            this.stockInbutton.UseVisualStyleBackColor = true;
            this.stockInbutton.Click += new System.EventHandler(this.stockInbutton_Click);
            // 
            // setupItembutton
            // 
            this.setupItembutton.Location = new System.Drawing.Point(30, 86);
            this.setupItembutton.Name = "setupItembutton";
            this.setupItembutton.Size = new System.Drawing.Size(92, 23);
            this.setupItembutton.TabIndex = 0;
            this.setupItembutton.Text = "Setup Item";
            this.setupItembutton.UseVisualStyleBackColor = true;
            this.setupItembutton.Click += new System.EventHandler(this.setupItembutton_Click);
            // 
            // setupCompanybutton
            // 
            this.setupCompanybutton.Location = new System.Drawing.Point(30, 57);
            this.setupCompanybutton.Name = "setupCompanybutton";
            this.setupCompanybutton.Size = new System.Drawing.Size(92, 23);
            this.setupCompanybutton.TabIndex = 0;
            this.setupCompanybutton.Text = "Setup Company";
            this.setupCompanybutton.UseVisualStyleBackColor = true;
            this.setupCompanybutton.Click += new System.EventHandler(this.setupCompanybutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Stock Management System";
            // 
            // StockManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockManagementUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockManagementUI";
            this.Load += new System.EventHandler(this.StockManagementUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setupCategorybutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button viewSalesTwoDatesbutton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button stockOutbutton;
        private System.Windows.Forms.Button stockInbutton;
        private System.Windows.Forms.Button setupItembutton;
        private System.Windows.Forms.Button setupCompanybutton;
        private System.Windows.Forms.Label label1;
    }
}