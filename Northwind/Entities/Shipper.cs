namespace Northwind.Entities
{
    public class Shipper
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public override string ToString()
        {
            return $"Shipper Details:\n" +
                   $"--------------------------------------------------\n" +
                   $"Shipper ID    : {ShipperID}\n" +
                   $"Company Name  : {CompanyName}\n" +
                   $"Phone         : {Phone}\n" +
                   $"--------------------------------------------------";
        }
    }
}
