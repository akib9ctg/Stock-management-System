namespace StockManagementSystemApp.UI
{
    partial class StockInUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemcomboBox = new System.Windows.Forms.ComboBox();
            this.stockIntextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.availableQuantitytextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reordertextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.companycomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.showNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock-In  Quantity:";
            // 
            // itemcomboBox
            // 
            this.itemcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemcomboBox.FormattingEnabled = true;
            this.itemcomboBox.Location = new System.Drawing.Point(130, 82);
            this.itemcomboBox.Name = "itemcomboBox";
            this.itemcomboBox.Size = new System.Drawing.Size(147, 21);
            this.itemcomboBox.TabIndex = 1;
            this.itemcomboBox.SelectedIndexChanged += new System.EventHandler(this.itemcomboBox_SelectedIndexChanged);
            // 
            // stockIntextBox
            // 
            this.stockIntextBox.Location = new System.Drawing.Point(130, 161);
            this.stockIntextBox.Name = "stockIntextBox";
            this.stockIntextBox.Size = new System.Drawing.Size(147, 20);
            this.stockIntextBox.TabIndex = 2;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(202, 204);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 3;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Available Quantity:";
            // 
            // availableQuantitytextBox
            // 
            this.availableQuantitytextBox.Location = new System.Drawing.Point(130, 135);
            this.availableQuantitytextBox.Name = "availableQuantitytextBox";
            this.availableQuantitytextBox.ReadOnly = true;
            this.availableQuantitytextBox.Size = new System.Drawing.Size(147, 20);
            this.availableQuantitytextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reorder Level:";
            // 
            // reordertextBox
            // 
            this.reordertextBox.Location = new System.Drawing.Point(130, 109);
            this.reordertextBox.Name = "reordertextBox";
            this.reordertextBox.ReadOnly = true;
            this.reordertextBox.Size = new System.Drawing.Size(147, 20);
            this.reordertextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Item:";
            // 
            // companycomboBox
            // 
            this.companycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companycomboBox.FormattingEnabled = true;
            this.companycomboBox.Location = new System.Drawing.Point(130, 53);
            this.companycomboBox.Name = "companycomboBox";
            this.companycomboBox.Size = new System.Drawing.Size(147, 21);
            this.companycomboBox.TabIndex = 1;
            this.companycomboBox.SelectedIndexChanged += new System.EventHandler(this.companycomboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Company Name:";
            // 
            // showNotification
            // 
            this.showNotification.AutoSize = true;
            this.showNotification.Location = new System.Drawing.Point(283, 138);
            this.showNotification.Name = "showNotification";
            this.showNotification.Size = new System.Drawing.Size(11, 13);
            this.showNotification.TabIndex = 4;
            this.showNotification.Text = "*";
            // 
            // StockInUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 301);
            this.Controls.Add(this.showNotification);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.reordertextBox);
            this.Controls.Add(this.availableQuantitytextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stockIntextBox);
            this.Controls.Add(this.companycomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "StockInUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockInUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemcomboBox;
        private System.Windows.Forms.TextBox stockIntextBox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox availableQuantitytextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reordertextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox companycomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label showNotification;
    }
}