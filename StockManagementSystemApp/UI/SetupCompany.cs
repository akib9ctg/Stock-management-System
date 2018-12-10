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
    public partial class SetupCompany : Form
    {
        public SetupCompany()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SetupCompanyManager setupCompanyManager=new SetupCompanyManager();
            if (CompanyNametextBox.Text != "")
            {
                MessageBox.Show(setupCompanyManager.AddComapny(CompanyNametextBox.Text));

            }
            else
            {
                MessageBox.Show("Required any Company Name");
            }
            CompanyNametextBox.Clear();
            SetDatainListView();
        }

        private void SetupCompany_Load(object sender, EventArgs e)
        {
            SetDatainListView();
        }
        void SetDatainListView()
        {
            CompanylistView.Items.Clear();
            int sr = 1;
            SetupCompanyManager setupCompanyManager = new SetupCompanyManager();
            List<Company> companyList = setupCompanyManager.GetAllData();
            foreach (Company company in companyList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = sr++.ToString();
                item.SubItems.Add(company.CompanyName);
                CompanylistView.Items.Add(item);
            }
        }
    }
}
