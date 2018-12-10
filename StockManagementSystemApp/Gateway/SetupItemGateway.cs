using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Gateway
{
    public class SetupItemGateway
    {
        string conString = ConfigurationManager.ConnectionStrings["ShopManagementDB"].ConnectionString;
        public int AddItem(Item item)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            string query = "insert into ItemTable values('"+item.ItemName+"','"+item.ReorderLevel+"','"+item.GetQuantity()+"','"+item.CompanyId+"','"+item.CategoryId+"')";
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

        public List<Item> GetAllItemsOfCompany(int companyId)
        {
            List<Item> itemList = new List<Item>();
            SqlConnection connection = new SqlConnection(conString);

            string query = "select *from ItemTable where companyId='" + companyId + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Item obItem = new Item();
                obItem.ItemName = reader["itemName"].ToString();
                obItem.Id= (int)reader["id"];
                obItem.ReorderLevel =(int)reader["reorderLevel"];
                obItem.SetQuantity((int)reader["availableQuantity"]);
                itemList.Add(obItem);
            }
            reader.Close();
            connection.Close();
            return itemList;
        } 
    }
}