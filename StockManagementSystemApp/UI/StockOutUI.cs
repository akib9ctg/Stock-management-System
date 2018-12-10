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
    public partial class StockOutUI : Form
    {
        public StockOutUI()
        {
            InitializeComponent();
            SetupCompanyManager setupCompanyManager = new SetupCompanyManager();
            companycomboBox.DisplayMember = "CompanyName";
            companycomboBox.ValueMember = "CompanyID";
            List<Company> companies = setupCompanyManager.GetAllData();
            companycomboBox.DataSource = companies;
            SetupItemManager setupItemManager = new SetupItemManager();
            itemcomboBox.DisplayMember = "ItemName";
            itemcomboBox.ValueMember = "Id";
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

        private void companycomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
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
        int sr = 1;

        private void addbutton_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem=new ListViewItem();
            listViewItem.Text = sr++.ToString();
            listViewItem.SubItems.Add(itemcomboBox.Text);
            listViewItem.SubItems.Add(companycomboBox.Text);
            listViewItem.SubItems.Add(quantitytextBox.Text);
            if (CheckAvailability(Convert.ToInt32(availableQuantitytextBox.Text), Convert.ToInt32(quantitytextBox.Text)))
            {
                
                foreach (ListViewItem lvi in stockOutlistView.Items)
                {
                    
                    string itemName = lvi.SubItems[1].Text;
                    string companyName = lvi.SubItems[2].Text;
                    int quantity = Convert.ToInt32(listViewItem.SubItems[3].Text);
                    if ((listViewItem.SubItems[1].Text == itemName) && (listViewItem.SubItems[2].Text == companyName))
                    {
                        lvi.SubItems[3].Text = (Convert.ToInt32(lvi.SubItems[3].Text) + quantity).ToString();
                        return;
                    }
                }
                stockOutlistView.Items.Add(listViewItem);
            }
            else
            {
                MessageBox.Show("Insufficient Stock");
            }
            
        }

        private bool CheckAvailability(int stockAvailability, int sockOutQuantity)
        {
            if (stockAvailability >= sockOutQuantity)
            {
                return true;
            }
            return false;
        }

        private void sellbutton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in stockOutlistView.Items)
            {
                ItemOut itemOut=new ItemOut();
                itemOut.ItemName = listViewItem.SubItems[1].Text;
                itemOut.CompanyName = listViewItem.SubItems[2].Text;
                itemOut.Quantity = Convert.ToInt32(listViewItem.SubItems[3].Text);
                itemOut.Condition = "Sell";
                itemOut.TimeStamp = GetTimestamp(DateTime.Now);
                StockManageManager stockManageManager=new StockManageManager();
                stockManageManager.StockOut(itemOut.Quantity, itemOut.ItemName, itemOut.CompanyName);
                stockManageManager.StockOutCondition(itemOut);
                
            }
            stockOutlistView.Items.Clear();
            quantitytextBox.Clear();
            GetUpdateData();
            int sr = 1;
        }
        public  String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd-HH-mm-ss");
        }

        private void demagebutton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in stockOutlistView.Items)
            {
                ItemOut itemOut = new ItemOut();
                itemOut.ItemName = listViewItem.SubItems[1].Text;
                itemOut.CompanyName = listViewItem.SubItems[2].Text;
                itemOut.Quantity = Convert.ToInt32(listViewItem.SubItems[3].Text);
                itemOut.Condition = "Demage";
                itemOut.TimeStamp = GetTimestamp(DateTime.Now);
                StockManageManager stockManageManager = new StockManageManager();
                stockManageManager.StockOut(itemOut.Quantity, itemOut.ItemName, itemOut.CompanyName);
                stockManageManager.StockOutCondition(itemOut);

            }
            stockOutlistView.Items.Clear();
            quantitytextBox.Clear();
            GetUpdateData();
            int sr = 1;
        }

        private void lostbutton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in stockOutlistView.Items)
            {
                ItemOut itemOut = new ItemOut();
                itemOut.ItemName = listViewItem.SubItems[1].Text;
                itemOut.CompanyName = listViewItem.SubItems[2].Text;
                itemOut.Quantity = Convert.ToInt32(listViewItem.SubItems[3].Text);
                itemOut.Condition = "Lost";
                itemOut.TimeStamp = GetTimestamp(DateTime.Now);
                StockManageManager stockManageManager = new StockManageManager();
                stockManageManager.StockOut(itemOut.Quantity, itemOut.ItemName, itemOut.CompanyName);
                stockManageManager.StockOutCondition(itemOut);
            }
            stockOutlistView.Items.Clear();
            quantitytextBox.Clear();
            GetUpdateData();
            int sr = 1;
        }
    }
}
