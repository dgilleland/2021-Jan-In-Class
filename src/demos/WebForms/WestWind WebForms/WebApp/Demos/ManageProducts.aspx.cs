using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WestWindSystem.BLL;
using WestWindSystem.Entities;

namespace WebApp.Demos
{
    public partial class ManageProducts : System.Web.UI.Page
    {
        #region Dependencies
        // There's an old practice of prefixing "hidden" or private fields
        // with an underscore (_)
        private ProductManager _Manager = new ProductManager();
        #endregion

        #region Page/Control Event Handlers
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = string.Empty;
            if(!IsPostBack) // GET
            {
                PopulateCategoryDropDown(AllCategories, "[Product Categories]");
                PopulateFilteredProducts(null);
                PopulateCategoryDropDown(Categories, "[Select a Category]");
                PopulateSupplierDropDown();
            }
        }

        protected void FilterByCategory_Click(object sender, EventArgs e)
        {
            int catId;
            if(int.TryParse(AllCategories.SelectedValue, out catId))
            {
                // Lookup the categories and populate the drop-down
                var info = _Manager.LookupProducts(catId);
                PopulateFilteredProducts(info);
            }
            else
            {
                MessageLabel.Text = "Select a category before clicking the [Filter] button";
            }
        }

        protected void SearchForProduct_Click(object sender, EventArgs e)
        {
            int prodId;
            if(int.TryParse(FilteredProducts.SelectedValue, out prodId))
            {
                // Get the data from the BLL
                var product = _Manager.LookupProduct(prodId);

                // Populate the form
                ProductID.Text = product.ProductID.ToString();
                ProductName.Text = product.ProductName;
                Suppliers.SelectedValue = product.SupplierID.ToString();
                Categories.SelectedValue = product.CategoryID.ToString();
                QtyPerUnit.Text = product.QuantityPerUnit;
                Price.Text = product.UnitPrice.ToString();
                OnOrder.Text = product.UnitsOnOrder.ToString();
                Discontinued.Checked = product.Discontinued;
            }
            else
            {
                MessageLabel.Text = "Select a product before searching for its details.";
            }
        }

        protected void AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product item = ParseProductDetails();
                int id = _Manager.Add(item);
                ProductID.Text = id.ToString();
                MessageLabel.Text = "Product added";
            }
            catch (Exception ex)
            {
                MessageLabel.Text = $"{ex.InnermostException().Message}.";
            }
        }

        protected void UpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if(int.TryParse(ProductID.Text, out id))
                {
                    Product item = ParseProductDetails();
                    item.ProductID = id;
                    _Manager.Update(item);
                    MessageLabel.Text = "Product details updated";
                }
                else
                {
                    MessageLabel.Text = "You can only update an existing product.";
                }
            }
            catch (Exception ex)
            {
                MessageLabel.Text = $"{ex.InnermostException().Message}.";
            }
        }

        protected void DeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (int.TryParse(ProductID.Text, out id))
                {
                    _Manager.Delete(id);
                    MessageLabel.Text = "Product deleted";
                    ClearForm_Click(sender, e);
                }
                else
                {
                    MessageLabel.Text = "You can only delete an existing product.";
                }
            }
            catch (Exception ex)
            {
                MessageLabel.Text = $"{ex.InnermostException().Message}.";
            }
        }

        protected void ClearForm_Click(object sender, EventArgs e)
        {
            ProductID.Text = string.Empty;
            ProductName.Text = string.Empty;
            Suppliers.SelectedIndex = -1;
            Categories.SelectedIndex = -1;
            QtyPerUnit.Text = string.Empty;
            Price.Text = string.Empty;
            OnOrder.Text = string.Empty;
            Discontinued.Checked = false;
        }
        #endregion

        #region Private helper methods
        private void PopulateFilteredProducts(List<Product> data)
        {
            FilteredProducts.DataSource = data;
            FilteredProducts.DataTextField = nameof(Product.ProductName);
            FilteredProducts.DataValueField = nameof(Product.ProductID);
            FilteredProducts.DataBind();

            FilteredProducts.Items.Insert(0, new ListItem("[Select a Product]", ""));
        }

        private void PopulateCategoryDropDown(DropDownList dropDown, string prompt)
        {
            // List all the categories
            dropDown.DataSource = _Manager.ListAllCategories();
            dropDown.DataTextField = nameof(Category.CategoryName);
            dropDown.DataValueField = nameof(Category.CategoryID);
            dropDown.DataBind();
            // Add my prompt
            dropDown.Items.Insert(0, new ListItem(prompt, ""));
        }

        void PopulateSupplierDropDown()
        {
            Suppliers.DataSource = _Manager.ListAllSuppliers();
            Suppliers.DataTextField = nameof(Supplier.CompanyName);
            Suppliers.DataValueField = nameof(Supplier.SupplierID);
            Suppliers.DataBind();
            Suppliers.Items.Insert(0, new ListItem("[Select a Supplier]", ""));
        }

        private Product ParseProductDetails()
        {
            int foreignKeyId;
            Product result = new Product();
            result.ProductName = ProductName.Text;
            if (int.TryParse(Suppliers.SelectedValue, out foreignKeyId))
                result.SupplierID = foreignKeyId;
            if (int.TryParse(Categories.SelectedValue, out foreignKeyId))
                result.CategoryID = foreignKeyId;
            result.QuantityPerUnit = QtyPerUnit.Text;
            decimal amount;
            if(decimal.TryParse(Price.Text, out amount))
                result.UnitPrice = amount;
            int qty;
            if (int.TryParse(OnOrder.Text, out qty))
                result.UnitsOnOrder = qty;
            result.Discontinued = Discontinued.Checked;
            return result;
        }
        #endregion
    }
}