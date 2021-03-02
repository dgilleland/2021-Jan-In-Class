using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Tells EF not to assume an IDENTITY constraint
        public string CustomerID { get; set; } // The PK for the table is NOT an IDENTITY column
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactEmail { get; set; }
        public int AddressID { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
