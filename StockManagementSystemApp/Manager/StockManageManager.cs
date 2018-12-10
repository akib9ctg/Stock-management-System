using System.Collections.Generic;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    public class StockManageManager
    {
        public string StockIn(int quantity, int itemId, int companyId)
        {
            StockManageGateway stockManageGateway=new StockManageGateway();
            int row=stockManageGateway.StockIn(quantity,itemId,companyId);
            if (row > 0)
            {
                return "Updated";
            }
            else
            {
                return "Failure";
            }
        }
        public string StockOut(int quantity, string itemName, string companyName )
        {
            StockManageGateway stockManageGateway = new StockManageGateway();
            int row = stockManageGateway.StockOut(quantity, itemName, companyName);
            if (row > 0)
            {
                return "Updated";
            }
            else
            {
                return "Failure";
            }
        }
        public string StockOutCondition(ItemOut itemOut)
        {
            StockManageGateway stockManageGateway = new StockManageGateway();
            int row = stockManageGateway.StockOutCondition(itemOut);
            if (row > 0)
            {
                return "Updated";
            }
            else
            {
                return "Failure";
            }
        }

        public List<Item> GetSalesItems(string fromDate, string toDate)
        {
            StockManageGateway stockManageGateway=new StockManageGateway();
            return stockManageGateway.GetSalesItems(fromDate,toDate);
             
        }

    }
}