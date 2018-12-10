using System;
using System.Collections.Generic;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    public class SetupItemManager
    {
        public string AddItem(Item item)
        {

            SetupItemGateway setupitemGateway = new SetupItemGateway();
            int row = setupitemGateway.AddItem(item);
            if (row == -1)
            {
                return "Same Item Name already Exist or Any Error Occurs";
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

        public List<Item> GetAllItemsOfCompany(int companyId)
        {
            SetupItemGateway setupItemGateway=new SetupItemGateway();
            return setupItemGateway.GetAllItemsOfCompany(companyId);
        } 
    }
}