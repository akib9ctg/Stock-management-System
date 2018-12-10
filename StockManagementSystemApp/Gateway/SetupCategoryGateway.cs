using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Gateway
{
    public class SetupCategoryGateway
    {
        string conString = ConfigurationManager.ConnectionStrings["ShopManagementDB"].ConnectionString;

        public int AddCategory(string categoryName)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            string query = "insert into CategoryList values('" + categoryName + "') ";
            try
            {
                SqlCommand command = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int row = command.ExecuteNonQuery();
                sqlConnection.Close();
                return row;
            }
            catch
            {
                return -1;
            }
        }
        public int Update(string previousName,string presentName)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            string query = "Update CategoryList set Name='" + presentName + "'where Name='" + previousName + "'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = command.ExecuteNonQuery();
            sqlConnection.Close();
            return row;
        }
        public List<Category> GetAllData()
        {
            List<Category> categorysList = new List<Category>();
            SqlConnection connection = new SqlConnection(conString);

            string query = "select *from CategoryList order by Name";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Category obCategory=new Category();
                obCategory.Name = reader["Name"].ToString();
                obCategory.Id = (int) reader["id"];
                categorysList.Add(obCategory);
            }
            reader.Close();
            connection.Close();
            return categorysList;
        } 
         
    }
}