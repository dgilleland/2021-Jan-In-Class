using System;
using System.Collections.Generic;
using System.Data.Entity; // Contains our DbContext class
using System.Linq;
using System.Web;

namespace WebApp.Data
{
    public class WestWindContext : DbContext
    {
        public WestWindContext() : base("name=WWdb")
        {
            Database.SetInitializer<WestWindContext>(null); // Don't try re-creating any db tables
        }

        // Declare a property for each table I want to access
        public DbSet<BuildVersion> BuildVersions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        // TODO: Homework! - Add properties for all the remaining tables/entities in your database/Entity classes
        public DbSet<Order> Orders { get; set; }
    }
}