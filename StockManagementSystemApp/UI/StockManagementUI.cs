using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemApp.UI
{
    public partial class StockManagementUI : Form
    {
        public StockManagementUI()
        {
            InitializeComponent();
           
        }

        protected override void OnClosed(EventArgs e)
        {
           // base.OnClosed(e);
            Application.Exit();
        }

        private void StockManagementUI_Load(object sender, EventArgs e)
        {

        }

        private void setupCategorybutton_Click(object sender, EventArgs e)
        {
            SetupCategory setupCategoryUI=new SetupCategory();
            setupCategoryUI.ShowDialog();
        }

        private void setupCompanybutton_Click(object sender, EventArgs e)
        {
            SetupCompany setupCompany=new SetupCompany();
            setupCompany.ShowDialog();
        }

        private void setupItembutton_Click(object sender, EventArgs e)
        {
            SetupItemUI setupItemUi=new SetupItemUI();
            setupItemUi.ShowDialog();
        }

        private void stockInbutton_Click(object sender, EventArgs e)
        {
            StockInUI stockInUi=new StockInUI();
            stockInUi.ShowDialog();
        }

        private void stockOutbutton_Click(object sender, EventArgs e)
        {
            StockOutUI stockOutUi=new StockOutUI();
            stockOutUi.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ViewItemUI viewItemUi=new ViewItemUI();
            viewItemUi.ShowDialog();

        }

        private void viewSalesTwoDatesbutton_Click(object sender, EventArgs e)
        {
            ViewSalesUI viewSalesUi=new ViewSalesUI();
            viewSalesUi.ShowDialog();
        }
    }
}
