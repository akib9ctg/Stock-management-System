using System;
using System.Collections.Generic;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    public class SetupCategoryManager
    {
        public string AddCategory(String categoryName)
        {

            SetupCategoryGateway setupCategoryGateway=new SetupCategoryGateway();
            int row = setupCategoryGateway.AddCategory(categoryName);
            if (row == -1)
            {
                return "Same Category already Exist or Any Error Occurs";
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

        public string Update(string previousName, string presentName)
        {
            SetupCategoryGateway setupCategoryGateway = new SetupCategoryGateway();
            int row = setupCategoryGateway.Update(previousName, presentName);
            if (row > 0)
            {
                return "Updated";
            }
            else
            {
                return "Failed";
            }

        }

        public List<Category> GetAllData()
        {
            SetupCategoryGateway setupCategoryGateway=new SetupCategoryGateway();
            return setupCategoryGateway.GetAllData();
        } 

    }
}