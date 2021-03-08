using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WestWindSystem.Entities;

namespace WestWindSystem.DAL
{
    // This class will represent my database as whole. I'm going to use Entity Framework to do all the
    // "Heavy Lifting" for communicating to the database.
    public class WestWindContext : DbContext
    {
        // Our constructor is going to identify aspects of where our database is and how we should interact with it
        public WestWindContext() : base("name=WWdb") // In the Web.config <add name="WWdb" ....
        {
            // Make sure that I don't automatically try to create database tables
            Database.SetInitializer<WestWindContext>(null);
        }

        // Properties for the Tables in the database
        public DbSet<Address> Addresses { get; set; }
        //          \ Entity/ \"Table"/
        public DbSet<BuildVersion> BuildVersions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
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