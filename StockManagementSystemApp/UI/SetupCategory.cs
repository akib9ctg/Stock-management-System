using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class SetupCategory : Form
    {
        public SetupCategory()
        {
            InitializeComponent();
        }

        private string previousName = "";

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveButton.Text == "Save")
            {
                SetupCategoryManager setupCategoryManager = new SetupCategoryManager();
                if (catogoryNametextBox.Text != "")
                {
                    MessageBox.Show(setupCategoryManager.AddCategory(catogoryNametextBox.Text));
                }
                else
                {
                    MessageBox.Show("Required any Category Name");
                }
            }
            else
            {
                SetupCategoryManager setupCategoryManager = new SetupCategoryManager();
                if (catogoryNametextBox.Text != null)
                {
                    MessageBox.Show(setupCategoryManager.Update(previousName,catogoryNametextBox.Text));
                    saveButton.Text = "Save";
                }
            }
            catogoryNametextBox.Clear();
            SetDatainListView();
            
        }

        private void SetupCategory_Load(object sender, EventArgs e)
        {
            SetDatainListView();
        }
        void SetDatainListView()
        {
            CategorylistView.Items.Clear();
            int sr = 1;
            SetupCategoryManager setupCategoryManager=new SetupCategoryManager();
            List<Category> categoryList = setupCategoryManager.GetAllData();
            foreach (Category category in categoryList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = sr++.ToString();
                item.SubItems.Add(category.Name);
                CategorylistView.Items.Add(item);
            }
        }

        private void CategorylistView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = CategorylistView.SelectedItems[0];
             previousName=catogoryNametextBox.Text = item.SubItems[1].Text;
            saveButton.Text = "Update";
           
        }
    }
}
