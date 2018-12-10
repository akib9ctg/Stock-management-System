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
    public partial class StockInUI : Form
    {
        public StockInUI()
        {
            InitializeComponent();
            SetupCompanyManager setupCompanyManager = new SetupCompanyManager();
            companycomboBox.DisplayMember = "CompanyName";
            companycomboBox.ValueMember = "CompanyID";
            List<Company> companies = setupCompanyManager.GetAllData();
            companycomboBox.DataSource = companies;
            SetupItemManager setupItemManager=new SetupItemManager();
            itemcomboBox.DisplayMember = "ItemName";
            itemcomboBox.ValueMember = "Id";
            GetUpdateData();
            

        }

        private void companycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupItemManager setupItemManager = new SetupItemManager();
            itemcomboBox.DisplayMember = "ItemName";
            itemcomboBox.ValueMember = "Id";
            List<Item> items = setupItemManager.GetAllItemsOfCompany((int)companycomboBox.SelectedValue);
            if (items.Count == 0)
            {
                reordertextBox.Text = "";
                availableQuantitytextBox.Text = "";
            }
            itemcomboBox.DataSource = items;
            foreach (Item item in items)
            {
                if (item.Id == (int)itemcomboBox.SelectedValue)
                {
                    reordertextBox.Text = item.ReorderLevel.ToString();
                    availableQuantitytextBox.Text = item.GetQuantity().ToString();
                }
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            StockManageManager stockManageManager=new StockManageManager();
            int value = Convert.ToInt32(stockIntextBox.Text);
            int itemId = (int) itemcomboBox.SelectedValue;
            int companyId = (int) companycomboBox.SelectedValue;
            MessageBox.Show(stockManageManager.StockIn(value, itemId, companyId));
            stockIntextBox.Clear();
            GetUpdateData();
        }

        private void itemcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           GetUpdateData();
        }

        private void GetUpdateData()
        {
            showNotification.Text = "";
            SetupItemManager setupItemManager = new SetupItemManager();
            List<Item> items = setupItemManager.GetAllItemsOfCompany((int)companycomboBox.SelectedValue);
            if (items.Count == 0)
            {
                reordertextBox.Text = "";
                availableQuantitytextBox.Text = "";
            }
            foreach (Item item in items)
            {
                if (item.Id == (int)itemcomboBox.SelectedValue)
                {
                    reordertextBox.Text = item.ReorderLevel.ToString();
                    availableQuantitytextBox.Text = item.GetQuantity().ToString();
                    if (item.ReorderLevel > item.GetQuantity())
                    {
                        reordertextBox.BackColor = Color.IndianRed;
                        reordertextBox.ForeColor = Color.White;
                        availableQuantitytextBox.BackColor = Color.IndianRed;
                        availableQuantitytextBox.ForeColor = Color.White;
                        showNotification.Text = "Your Quantity is below Reorder Level.";
                    }
                    else
                    {
                        reordertextBox.ResetBackColor();
                        reordertextBox.ResetForeColor();
                        availableQuantitytextBox.ResetBackColor();
                        availableQuantitytextBox.ResetForeColor();
                    }
                }
            }
        }
        
    }
}
