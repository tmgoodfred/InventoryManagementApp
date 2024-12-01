namespace InventoryManagementApp
{
    public class ProductInventory : Product
    {
        public int Quantity { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}