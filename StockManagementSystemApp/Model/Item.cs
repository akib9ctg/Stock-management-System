using System;

namespace StockManagementSystemApp.Model
{
    public class Item
    {
        
        public int Id { get; set; }
        public String  ItemName { get; set; }
        public int  ReorderLevel { get; set; }
        public int  CategoryId { get; set; }
        public int CompanyId { get; set; }

        private int quantity = 0;
        public string CompanyName { get; set; }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int value)
        {
            quantity = value;
        }


    }
}