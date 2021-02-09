using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data
{
    public class Address
    {
        public int AddressID { get; set; }

        [Column("Address")]
        public string Street { get; set; }

        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
