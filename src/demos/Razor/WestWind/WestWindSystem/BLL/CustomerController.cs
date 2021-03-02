using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Data; // My namespace for DAL/Entity classes

namespace WestWindSystem.BLL
{
    /// <summary>
    /// Supports the CRUD operations and directly interacts with the database (DAL)
    /// </summary>
    public class CustomerController
    {
        public List<Customer> LoadCustomers(string partialName)
        {
            // Do a search of the database
            using (var context = new WestWindContext()) // Using block will close the connection afterwards
            {
                // LINQ - Language INtegrated Query
                var result = from row in context.Customers
                             where row.CompanyName.Contains(partialName)
                             select row;
                return result.ToList();
            }
        }

        public Customer GetCustomer(string customerId)
        {
            Customer customer;
            using (var context = new WestWindContext()) // using will close the database connection after we get the data
            {
                // We can look up a single row (instance) from our database by using the .Find() method
                // and sending in the Primary Key value for the customer we want to find.
                customer = context.Customers.Find(customerId);
            }
            return customer;
        }
    }
}
