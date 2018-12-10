namespace StockManagementSystemApp.Model
{
    public class ViewItem
    {
        public string ItemName { get; set; }
        public string CompanyName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public int  ReorderLevel { get; set; }
    }
}