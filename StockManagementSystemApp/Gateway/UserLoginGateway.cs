using System.Configuration;
using System.Data.SqlClient;

namespace StockManagementSystemApp.Gateway
{
    public class UserLoginGateway
    {
        string conString = ConfigurationManager.ConnectionStrings["ShopManagementDB"].ConnectionString;

        public bool CheckLogin(string userId, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            string query = "select *from UserTable where userID='" + userId + "'"+"AND password='"+password+"'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            sqlConnection.Close();
            return isExist;
        }

    }
}