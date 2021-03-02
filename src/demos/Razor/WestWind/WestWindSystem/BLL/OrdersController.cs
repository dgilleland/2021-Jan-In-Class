using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Data;

namespace WestWindSystem.BLL
{
    /// <summary>
    /// Handles CRUD processing for data in the Orders table
    /// </summary>
    public class OrdersController
    {
        // Determine the "contract" to get all the orders belonging to a specific customer
        public List<Order> GetCustomerOrders(string customerId)
        {
            using (var context = new WestWindContext())
            {
                // I'll use a C# LINQ statement to query the database for orders belonging to a specific customer
                var result = from purchase in context.Orders
                             where purchase.CustomerID == customerId
                             orderby purchase.OrderDate descending // Most recent purchases first
                             select purchase;

                // Return my results, transforming it to
                // a List<Order>
                return result.ToList();
            }
        }

        public Order GetOrder(int orderId)
        {
            using (var context = new WestWindContext())
            {
                Order existing = context.Orders.Find(orderId);
                return existing;
            }
        }

        public int AddOrder(Order item)
        {
            // We need to use our virtual database class - our DbContext
            // Ensure that after we "open" the connection to the database, it (the connection) is properly closed
            using (var context = new WestWindContext()) // Use (open) our virtual database (that connects to our physical database)
            {
                // 2) Add that to our "virtual" table
                context.Orders.Add(item);
                // 3) Save the changes - (actually putting the data into the database)
                context.SaveChanges();
                // Give the ID of the new order
                return item.OrderID;
            }
        }

        public void UpdateOrder(Order item)
        {
            using (var context = new WestWindContext())
            {
                // 2) Associate the Order object with my DbContext as an entry that should already be in the database
                var existing = context.Entry(item);
                existing.State = System.Data.Entity.EntityState.Modified; // This object's data has changed
                                                                          // 3) Save the changes
                context.SaveChanges();
            }
        }

        public void DeleteOrder(int orderId)
        {
            using (var context = new WestWindContext())
            {
                // 1) Find the order
                Order existing = context.Orders.Find(orderId);
                // 2) Remove the order
                context.Orders.Remove(existing);
                // 3) Save the changes
                context.SaveChanges();
            }
        }
    }
}
