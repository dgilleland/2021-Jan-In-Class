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
        // There's an old practice of prefixing "hidden" or private fields
        // with an underscore (_)
        private ProductManager _Manager = new ProductManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = string.Empty;
            if(!IsPostBack) // GET
            {
                PopulateCategoryDropDown(AllCategories, "[Product Categories]");
                PopulateFilteredProducts(null);
                PopulateCategoryDropDown(Categories, "[Select a Category]");
            }
        }

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
        #endregion

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
    }
}