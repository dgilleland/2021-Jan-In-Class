using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.Entities;
using WestWindSystem.DAL;

namespace WestWindSystem.BLL
{
    /// <summary>
    /// Handles all of the CRUD behaviour for interacting with the Orders table.
    /// </summary>
    public class OrdersController
    {
        public List<Order> GetCustomerOrders(string customerId)
        {
            using (var context = new WestWindContext())
            {
                // I'll use a C# LINQ statement to query the database for the orders belong to a specific customer
                var result = from purchase in context.Orders
                             where purchase.CustomerID == customerId
                             orderby purchase.OrderDate descending // Most recent purchases first
                             select purchase;
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

        public int AddOrder(Order newOrder)
        {
            using (var context = new WestWindContext())
            {
                // 2) Add this to the "virtual" database (our DbContext object)
                context.Orders.Add(newOrder);
                // 3) Saving the changes to the "actual" database
                context.SaveChanges(); // This is when the actual SQL INSERT occurs

                return newOrder.OrderID;
            }
        }

        public void UpdateOrder(Order updated)
        {
            using (var context = new WestWindContext())
            {
                // 2) Note the changes to the order data
                var existing = context.Entry(updated);  // Associate the updatedOrder with an existing order
                existing.State = System.Data.Entity.EntityState.Modified; // Note that the data for this order has changed
                                                                          // 3) Save the changes to the actual database
                context.SaveChanges();
            }
        }

        public void DeleteOrder(int orderId)
        {
            using (var context = new WestWindContext())
            {
                // 1) Find the order
                Order existingOrder = context.Orders.Find(orderId); // This will grab the order from the db
                // 2) Mark that order for deletion
                context.Orders.Remove(existingOrder);
                // 3) Save the changes to the database
                context.SaveChanges();
            }
        }
    }
}
