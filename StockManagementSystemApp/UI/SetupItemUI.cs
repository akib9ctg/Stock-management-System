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
    public partial class SetupItemUI : Form
    {
        public SetupItemUI()
        {
            InitializeComponent();
            categorycomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            companycomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SetupCategoryManager setupCategoryManager=new SetupCategoryManager();
            categorycomboBox.DisplayMember = "Name";
            categorycomboBox.ValueMember = "Id";
            List<Category> categories = setupCategoryManager.GetAllData();
            categorycomboBox.DataSource = categories;
            SetupCompanyManager setupCompanyManager=new SetupCompanyManager();
            companycomboBox.DisplayMember = "CompanyName";
            companycomboBox.ValueMember = "CompanyID";
            List<Company> companies = setupCompanyManager.GetAllData();
            companycomboBox.DataSource = companies;

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            Item item=new Item();
            item.ItemName = itemtextBox.Text;
            item.ReorderLevel = Convert.ToInt32(reordertextBox.Text);
            item.CategoryId = (int) categorycomboBox.SelectedValue;
            item.CompanyId = (int) companycomboBox.SelectedValue;
            SetupItemManager setupItemManager=new SetupItemManager();
            MessageBox.Show(setupItemManager.AddItem(item));

        }
    }
}
