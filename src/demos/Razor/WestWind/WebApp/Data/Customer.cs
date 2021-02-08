using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data
{
    public partial class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactEmail { get; set; }
        public int AddressID { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
