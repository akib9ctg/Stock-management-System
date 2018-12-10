using System;
using System.Collections.Generic;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    public class SetupCompanyManager
    {
        public string AddComapny(String companyName)
        {

            SetupCompanyGateway setupCompanyGateway=new SetupCompanyGateway();
            int row = setupCompanyGateway.AddCompany(companyName);
            if (row == -1)
            {
                return "Same Comapany Name already Exist or Any Error Occurs";
            }
            else if (row > 0)
            {
                return "Saved";
            }
            else
            {
                return "Not Saved";
            }
        }

       

        public List<Company> GetAllData()
        {
            SetupCompanyGateway setupCompanyGateway=new SetupCompanyGateway();
            return setupCompanyGateway.GetAllData();
        } 
         
    }
}