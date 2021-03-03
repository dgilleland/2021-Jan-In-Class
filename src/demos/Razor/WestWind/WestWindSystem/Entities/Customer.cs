using System.ComponentModel.DataAnnotations.Schema;

namespace WestWindSystem.Entities
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Indicate how the Db handles the PK column
        public string CustomerID { get; set; } // Primary Key - 
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactEmail { get; set; }
        public int AddressID { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
