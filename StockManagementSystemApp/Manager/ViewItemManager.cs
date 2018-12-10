using System.Collections.Generic;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    public class ViewItemManager
    {
        public List<ViewItem> GetAllViewItems(int companyId, int categoryId)
        {
            ViewItemGateway viewItemGateway=new ViewItemGateway();
            return viewItemGateway.GetAllViewItems(companyId, categoryId);
             
        }
    }
}