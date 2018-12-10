using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Gateway
{
    public class StockManageGateway
    {
        string conString = ConfigurationManager.ConnectionStrings["ShopManagementDB"].ConnectionString;
        public int StockIn(int quantity,int itemId,int companyId)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            string query = "UPDATE ItemTable SET availableQuantity = availableQuantity+  '" + quantity + "' where id='"+itemId+"' AND companyId='"+companyId+"'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int rowAffected = command.ExecuteNonQuery();
            sqlConnection.Close();
            return rowAffected;
        }


        public int StockOut(int quantity, string itemName, string companyName)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            string query = "UPDATE ItemTable SET availableQuantity = availableQuantity- '" + quantity + "' where id=(select id from ItemTable where itemName= '" + itemName + "')  AND companyId=(select id from CompanyNameTable where CompanyName='" + companyName + "')";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int rowAffected = command.ExecuteNonQuery();
            sqlConnection.Close();
            return rowAffected;
        }
        public int StockOutCondition(ItemOut itemOut)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            string query = "Insert into StockOutTable values('"+itemOut.ItemName+"','"+itemOut.CompanyName+"','"+itemOut.Quantity+"','"+itemOut.Condition+"','"+itemOut.TimeStamp+"')";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int rowAffected = command.ExecuteNonQuery();
            sqlConnection.Close();
            return rowAffected;
        }

        public List<Item> GetSalesItems(string fromDate, string toDate)
        {
            List<Item> salesItems = new List<Item>();
            SqlConnection connection = new SqlConnection(conString);

            string query = "select company,item, quantity from StockOutTable where condition='sell' AND timeStamp between '"+fromDate+"'AND '"+toDate+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Item obItem = new Item();
                obItem.ItemName = reader["item"].ToString();
                obItem.SetQuantity(((int)reader["quantity"]));
                obItem.CompanyName = reader["company"].ToString();
                salesItems.Add(obItem);
            }
            reader.Close();
            connection.Close();
            return salesItems;
            
        } 
        

    }
}