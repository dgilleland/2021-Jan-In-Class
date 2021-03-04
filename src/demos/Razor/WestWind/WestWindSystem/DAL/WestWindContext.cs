using System;
using System.Collections.Generic;
using System.Data.Entity; // Contains our DbContext class
using System.Linq;
using System.Web;
using WestWindSystem.Entities;

namespace WestWindSystem.DAL
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
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<ManifestItem> ManifestItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Territory> Territories { get; set; }
    }
}