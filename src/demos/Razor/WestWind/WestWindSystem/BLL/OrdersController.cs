using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Data;

namespace WestWindSystem.BLL
{
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
    }
}
