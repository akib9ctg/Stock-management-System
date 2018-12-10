using StockManagementSystemApp.Gateway;

namespace StockManagementSystemApp.Manager
{
    public class UserLoginManager
    {
        public string CheckLogin(string userId, string password)
        {
            UserLoginGateway userLoginGateway=new UserLoginGateway();
            if (userLoginGateway.CheckLogin(userId, password))
            {
                return "Login Successful";
            }
            else
            {
                return "Invalid Id or Password";
            }

        } 
    }
}