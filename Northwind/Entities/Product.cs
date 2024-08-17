namespace Northwind.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public override string ToString()
        {
            return 
                   $"--------------------------------------------------- \n"+
                   $"Product ID: {ProductID}\n" +
                   $"Product Name: {ProductName}\n" +
                   $"Supplier ID: {(SupplierID.HasValue ? SupplierID.Value.ToString() : "N/A")}\n" +
                   $"Category ID: {(CategoryID.HasValue ? CategoryID.Value.ToString() : "N/A")}\n" +
                   $"Quantity Per Unit: {QuantityPerUnit}\n" +
                   $"Unit Price: {UnitPrice:C}\n" +
                   $"Units In Stock: {UnitsInStock}\n" +
                   $"Units On Order: {UnitsOnOrder}\n" +
                   $"Reorder Level: {ReorderLevel}\n" +
                   $"Discontinued: {(Discontinued ? "Yes" : "No")} \n" +
                   $"--------------------------------------------------- \n ";
        }
    }
}
