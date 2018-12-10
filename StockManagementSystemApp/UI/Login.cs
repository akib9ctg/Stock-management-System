using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.UI;

namespace StockManagementSystemApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            UserLoginManager userLoginManager=new UserLoginManager();
            string result = userLoginManager.CheckLogin(useIDtextBox.Text, passwordtextBox.Text);
            MessageBox.Show(result);
            if (result == "Login Successful")
            {
                StockManagementUI stockManagementUi=new StockManagementUI();
                stockManagementUi.Show();
                
            }

        }

    }
}
