namespace Northwind.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public override string ToString()
        {
            return $"Order Details:\n" +
                   $"--------------------------------------------------\n" +
                   $"Order ID       : {OrderID}\n" +
                   $"Customer ID    : {CustomerID}\n" +
                   $"Employee ID    : {EmployeeID?.ToString() ?? "N/A"}\n" +
                   $"Order Date     : {OrderDate:yyyy-MM-dd}\n" +
                   $"Required Date  : {RequiredDate:yyyy-MM-dd}\n" +
                   $"Shipped Date   : {ShippedDate?.ToString("yyyy-MM-dd") ?? "N/A"}\n" +
                   $"Ship Via       : {ShipVia}\n" +
                   $"Freight        : {Freight:C}\n" +
                   $"Ship Name      : {ShipName}\n" +
                   $"Ship Address   : {ShipAddress}\n" +
                   $"Ship City      : {ShipCity}\n" +
                   $"Ship Region    : {ShipRegion}\n" +
                   $"Ship PostalCode: {ShipPostalCode}\n" +
                   $"Ship Country   : {ShipCountry}\n" +
                   $"--------------------------------------------------";
        }

    }
}
