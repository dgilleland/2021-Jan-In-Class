using System.ComponentModel.DataAnnotations.Schema;

namespace WestWindSystem.Entities
{
    public class Address // Addresses
    {
        public int AddressID { get; set; }

        [Column("Address")] // An annoation that identifies the column name that this proper maps to
        public string Street { get; set; }

        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        [NotMapped]
        public string AbbreviatedAddress
        {
            get
            {
                return $"{City}, {Street}";
            }
        }
    }
}
