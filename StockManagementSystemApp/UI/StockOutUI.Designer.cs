namespace StockManagementSystemApp.UI
{
    partial class StockOutUI
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
            this.showNotification = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.reordertextBox = new System.Windows.Forms.TextBox();
            this.availableQuantitytextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.companycomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockOutlistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sellbutton = new System.Windows.Forms.Button();
            this.demagebutton = new System.Windows.Forms.Button();
            this.lostbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showNotification
            // 
            this.showNotification.AutoSize = true;
            this.showNotification.Location = new System.Drawing.Point(299, 106);
            this.showNotification.Name = "showNotification";
            this.showNotification.Size = new System.Drawing.Size(11, 13);
            this.showNotification.TabIndex = 16;
            this.showNotification.Text = "*";
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(218, 155);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 15;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // reordertextBox
            // 
            this.reordertextBox.Location = new System.Drawing.Point(146, 77);
            this.reordertextBox.Name = "reordertextBox";
            this.reordertextBox.ReadOnly = true;
            this.reordertextBox.Size = new System.Drawing.Size(147, 20);
            this.reordertextBox.TabIndex = 12;
            // 
            // availableQuantitytextBox
            // 
            this.availableQuantitytextBox.Location = new System.Drawing.Point(146, 103);
            this.availableQuantitytextBox.Name = "availableQuantitytextBox";
            this.availableQuantitytextBox.ReadOnly = true;
            this.availableQuantitytextBox.Size = new System.Drawing.Size(147, 20);
            this.availableQuantitytextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 24);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Company Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 53);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 80);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reorder Level:";
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.Location = new System.Drawing.Point(146, 129);
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.Size = new System.Drawing.Size(147, 20);
            this.quantitytextBox.TabIndex = 14;
            // 
            // companycomboBox
            // 
            this.companycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companycomboBox.FormattingEnabled = true;
            this.companycomboBox.Location = new System.Drawing.Point(146, 21);
            this.companycomboBox.Name = "companycomboBox";
            this.companycomboBox.Size = new System.Drawing.Size(147, 21);
            this.companycomboBox.TabIndex = 10;
            this.companycomboBox.SelectedIndexChanged += new System.EventHandler(this.companycomboBox_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Available Quantity:";
            // 
            // itemcomboBox
            // 
            this.itemcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemcomboBox.FormattingEnabled = true;
            this.itemcomboBox.Location = new System.Drawing.Point(146, 50);
            this.itemcomboBox.Name = "itemcomboBox";
            this.itemcomboBox.Size = new System.Drawing.Size(147, 21);
            this.itemcomboBox.TabIndex = 11;
            this.itemcomboBox.SelectedIndexChanged += new System.EventHandler(this.itemcomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 132);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantity:";
            // 
            // stockOutlistView
            // 
            this.stockOutlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.stockOutlistView.GridLines = true;
            this.stockOutlistView.Location = new System.Drawing.Point(12, 198);
            this.stockOutlistView.Name = "stockOutlistView";
            this.stockOutlistView.Size = new System.Drawing.Size(467, 226);
            this.stockOutlistView.TabIndex = 17;
            this.stockOutlistView.UseCompatibleStateImageBehavior = false;
            this.stockOutlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sr";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Company";
            this.columnHeader3.Width = 149;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            // 
            // sellbutton
            // 
            this.sellbutton.Location = new System.Drawing.Point(218, 430);
            this.sellbutton.Name = "sellbutton";
            this.sellbutton.Size = new System.Drawing.Size(75, 23);
            this.sellbutton.TabIndex = 18;
            this.sellbutton.Text = "Sell";
            this.sellbutton.UseVisualStyleBackColor = true;
            this.sellbutton.Click += new System.EventHandler(this.sellbutton_Click);
            // 
            // demagebutton
            // 
            this.demagebutton.Location = new System.Drawing.Point(312, 430);
            this.demagebutton.Name = "demagebutton";
            this.demagebutton.Size = new System.Drawing.Size(75, 23);
            this.demagebutton.TabIndex = 19;
            this.demagebutton.Text = "Demage";
            this.demagebutton.UseVisualStyleBackColor = true;
            this.demagebutton.Click += new System.EventHandler(this.demagebutton_Click);
            // 
            // lostbutton
            // 
            this.lostbutton.Location = new System.Drawing.Point(404, 430);
            this.lostbutton.Name = "lostbutton";
            this.lostbutton.Size = new System.Drawing.Size(75, 23);
            this.lostbutton.TabIndex = 20;
            this.lostbutton.Text = "Lost";
            this.lostbutton.UseVisualStyleBackColor = true;
            this.lostbutton.Click += new System.EventHandler(this.lostbutton_Click);
            // 
            // StockOutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 465);
            this.Controls.Add(this.lostbutton);
            this.Controls.Add(this.demagebutton);
            this.Controls.Add(this.sellbutton);
            this.Controls.Add(this.stockOutlistView);
            this.Controls.Add(this.showNotification);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.reordertextBox);
            this.Controls.Add(this.availableQuantitytextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantitytextBox);
            this.Controls.Add(this.companycomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "StockOutUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockOutUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showNotification;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox reordertextBox;
        private System.Windows.Forms.TextBox availableQuantitytextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantitytextBox;
        private System.Windows.Forms.ComboBox companycomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itemcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView stockOutlistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button sellbutton;
        private System.Windows.Forms.Button demagebutton;
        private System.Windows.Forms.Button lostbutton;
    }
}