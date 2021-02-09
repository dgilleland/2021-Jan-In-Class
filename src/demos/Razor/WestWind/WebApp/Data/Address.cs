using System.ComponentModel.DataAnnotations.Schema; // ColumnAttribute is member of the Schema

namespace WebApp.Data
{
    // ![](3862A08B12A39F1707AAF17E5D8AA0B8.png)
    public class Address // Table Addresses
    {
        public int AddressID { get; set; }

        // An annotation is extra compile-time information about a given property/class/etc.
        // Entity Framework will look at the "blueprint" for the Address class and examine it for
        // annotations about how it should adapt its default mapping conventions
        [Column("Address")] // The [Column] annotation identifies the name of the column in the db table
        public string Street { get; set; } // Street is a programmer-defined name for the Address column

        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
