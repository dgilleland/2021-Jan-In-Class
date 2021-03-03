using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WestWindSystem.Entities
{
    // For practical purposes, since I'm using Entity Framework, I want to follow certain
    // "conventions" that will fit with the default "mapping" that EF uses to associate
    // my Entity classes with my database tables.
    // My entity class will represent a single row's worth of data from the database table.
    public class Order // I use the singular version of the table name
    {
        // I create one property for each column in my database table.
        // Pay attention to the data type and the spelling.
        public int OrderID { get; set; }
        public int? SalesRepID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public decimal? Freight { get; set; }
        public bool Shipped { get; set; }
        public string ShipName { get; set; }
        public int? ShipAddressID { get; set; }
        public string Comments { get; set; }
    }
}