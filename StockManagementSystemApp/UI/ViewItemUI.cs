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
    public partial class ViewItemUI : Form
    {
        public ViewItemUI()
        {
            InitializeComponent();
            SetupCompanyManager setupCompanyManager = new SetupCompanyManager();
            companycomboBox.DisplayMember = "CompanyName";
            companycomboBox.ValueMember = "CompanyID";
            List<Company> companies = setupCompanyManager.GetAllData();
            companycomboBox.DataSource = companies;
            SetupCategoryManager setupCategoryManager=new SetupCategoryManager();
            categorycomboBox.DisplayMember = "Name";
            categorycomboBox.ValueMember = "Id";
            List<Category> categories = setupCategoryManager.GetAllData();
            categorycomboBox.DataSource = categories;

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            int sr =1;
            viewItemlistView.Items.Clear();
            ViewItemManager viewItemManager=new ViewItemManager();
            List<ViewItem> allViewItems=viewItemManager.GetAllViewItems((int) companycomboBox.SelectedValue,(int) categorycomboBox.SelectedValue);
            foreach (ViewItem viewItem in allViewItems)
            {
                ListViewItem item = new ListViewItem();
                item.Text = sr++.ToString();
                item.SubItems.Add(viewItem.ItemName);
                item.SubItems.Add(viewItem.CompanyName);
                item.SubItems.Add(viewItem.Category);
                item.SubItems.Add(viewItem.Quantity.ToString());
                item.SubItems.Add(viewItem.ReorderLevel.ToString());
                viewItemlistView.Items.Add(item);
            }
        }
    }
}
