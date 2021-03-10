using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.Entities; // Namespace for the Customer
using WestWindSystem.DAL;      // Namespace for the WestWindContext

namespace WestWindSystem.BLL
{
    /// <summary>
    /// Provides CRUD access to data in the Customers table
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

        public List<Customer> ListAllCustomers()
        {
            using (var context = new WestWindContext())
            {
                return context.Customers.ToList();
            }
        }

        public Customer FindCustomer(string customerId)
        {
            Customer customer = null;
            using (var context = new WestWindContext())
            {
                // We can look up a single row (instance) from our database by using the .Find() method
                // and send in the Primary Key value for the customer we want to find.
                customer = context.Customers.Find(customerId);
            }
            return customer;
        }
    }
}
