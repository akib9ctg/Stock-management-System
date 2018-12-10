using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Gateway
{
    public class SetupCompanyGateway
    {
        string conString = ConfigurationManager.ConnectionStrings["ShopManagementDB"].ConnectionString;
        public int AddCompany(string companyName)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            string query = "insert into CompanyNameTable values('" + companyName + "') ";
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
        
        public List<Company> GetAllData()
        {
            List<Company> companyList = new List<Company>();
            SqlConnection connection = new SqlConnection(conString);

            string query = "select *from CompanyNameTable order by CompanyName";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Company company=new Company();
                company.CompanyName = reader["CompanyName"].ToString();
                company.CompanyID = (int) reader["id"];
                companyList.Add(company);
            }
            reader.Close();
            connection.Close();
            return companyList;
        }
 
    }
}