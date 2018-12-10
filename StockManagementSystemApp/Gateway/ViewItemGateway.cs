using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Gateway
{
    public class ViewItemGateway
    {
        string conString = ConfigurationManager.ConnectionStrings["ShopManagementDB"].ConnectionString;

        public List<ViewItem> GetAllViewItems(int companyId,int categoryId)
        {
            List<ViewItem> itemList = new List<ViewItem>();
            SqlConnection connection = new SqlConnection(conString);

            string query = "select ItemTable.itemName,ItemTable.reorderLevel, ItemTable.availableQuantity,CategoryList.Name,CompanyNameTable.CompanyName from " +
                           "ItemTable INNER JOIN CategoryList on ItemTable.categoryId= CategoryList.id"+
                            " INNER JOIN CompanyNameTable on ItemTable.companyId=CompanyNameTable.id where" +
                           " ItemTable.categoryId= '" + categoryId + "' AND ItemTable.companyId= '"+companyId+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ViewItem obItem = new ViewItem();
                obItem.ItemName = reader["itemName"].ToString();
                obItem.CompanyName = reader["CompanyName"].ToString();
                obItem.ReorderLevel = (int)reader["reorderLevel"];
                obItem.Quantity=((int)reader["availableQuantity"]);
                obItem.Category = reader["Name"].ToString();
                itemList.Add(obItem);
            }
            reader.Close();
            connection.Close();
            return itemList;
        } 
    }
}