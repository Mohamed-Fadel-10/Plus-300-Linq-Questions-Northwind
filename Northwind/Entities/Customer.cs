namespace Northwind.Entities
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

       
        public override string ToString()
        {
            return
                   $"--------------------------------------------------- \n "+
                   $"Customer ID: {CustomerID}\n" +
                   $"Company Name: {CompanyName}\n" +
                   $"Contact Name: {ContactName}\n" +
                   $"Contact Title: {ContactTitle}\n" +
                   $"Address: {Address}\n" +
                   $"City: {City}\n" +
                   $"Region: {Region}\n" +
                   $"Postal Code: {PostalCode}\n" +
                   $"Country: {Country}\n" +
                   $"Phone: {Phone}\n" +
                   $"Fax: {Fax}\n"+
                   $"--------------------------------------------------- \n ";
            ;
        }
    }
}
