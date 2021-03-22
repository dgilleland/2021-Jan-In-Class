using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    // You can call your BLL class anything that makes sense
    public class ProductManager
    {
        #region Product Command methods - INSERT/UPDATE/DELETE
        public int Add(Product item)
        {
            using(var context = new WestWindContext())
            {
                context.Products.Add(item);
                context.SaveChanges();
                return item.ProductID;
            }
        }
        public void Update(Product item)
        {
            using (var context = new WestWindContext())
            {
                var existing = context.Entry(item);
                existing.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int productId)
        {
            using (var context = new WestWindContext())
            {
                var found = context.Products.Find(productId);
                context.Products.Remove(found);
                context.SaveChanges();
            }
        }
        #endregion

        #region Product Query methods and Related "Lookup" methods
        public List<Category> ListAllCategories()
        {
            using(var context = new WestWindContext())
            {
                return context.Categories.ToList();
            }
        }
 
        public List<Supplier> ListAllSuppliers()
        {
            using (var context = new WestWindContext())
            {
                return context.Suppliers
                              .OrderBy(s => s.CompanyName)
                              .ToList();
            }
        }
 
        public List<Product> LookupProducts(int categoryId)
        {
            using (var context = new WestWindContext())
            {
                return context.Products
                              // .Where() is an extension method for filtering
                              .Where(item => item.CategoryID == categoryId)
                              // .OrderBy() is an extension method for sorting
                              .OrderBy(item => item.ProductName)
                              .ToList();
            }
        }

        public Product LookupProduct(int productId)
        {
            using (var context = new WestWindContext())
            {
                return context.Products.Find(productId);
            }
        }
        #endregion
    }
}
