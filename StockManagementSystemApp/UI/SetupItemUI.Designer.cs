namespace StockManagementSystemApp.UI
{
    partial class SetupItemUI
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
            this.categorycomboBox = new System.Windows.Forms.ComboBox();
            this.itemtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.companycomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reordertextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // categorycomboBox
            // 
            this.categorycomboBox.FormattingEnabled = true;
            this.categorycomboBox.Location = new System.Drawing.Point(175, 29);
            this.categorycomboBox.Name = "categorycomboBox";
            this.categorycomboBox.Size = new System.Drawing.Size(168, 21);
            this.categorycomboBox.TabIndex = 1;
            // 
            // itemtextBox
            // 
            this.itemtextBox.Location = new System.Drawing.Point(175, 84);
            this.itemtextBox.Name = "itemtextBox";
            this.itemtextBox.Size = new System.Drawing.Size(168, 20);
            this.itemtextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company Name:";
            // 
            // companycomboBox
            // 
            this.companycomboBox.FormattingEnabled = true;
            this.companycomboBox.Location = new System.Drawing.Point(175, 57);
            this.companycomboBox.Name = "companycomboBox";
            this.companycomboBox.Size = new System.Drawing.Size(168, 21);
            this.companycomboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reorder Level:";
            // 
            // reordertextBox
            // 
            this.reordertextBox.Location = new System.Drawing.Point(175, 110);
            this.reordertextBox.Name = "reordertextBox";
            this.reordertextBox.Size = new System.Drawing.Size(168, 20);
            this.reordertextBox.TabIndex = 2;
            this.reordertextBox.Text = "0";
            this.reordertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(280, 149);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 3;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // SetupItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 227);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.reordertextBox);
            this.Controls.Add(this.itemtextBox);
            this.Controls.Add(this.companycomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categorycomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetupItemUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetupItemUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categorycomboBox;
        private System.Windows.Forms.TextBox itemtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox companycomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reordertextBox;
        private System.Windows.Forms.Button savebutton;
    }
}