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
    public partial class SearchProducts : System.Web.UI.Page
    {
        #region Depedencies on my BLL class
        private ProductManager _ProductManager = new ProductManager();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SuppliersDropDown.DataSource = _ProductManager.ListAllSuppliers();
                SuppliersDropDown.DataTextField = nameof(Supplier.CompanyName);
                SuppliersDropDown.DataValueField = nameof(Supplier.SupplierID);
                SuppliersDropDown.DataBind();
                SuppliersDropDown.Items.Insert(0, new ListItem("[Select a supplier]", ""));
            }
        }

        protected void SearchBySupplier_Click(object sender, EventArgs e)
        {
            if(SuppliersDropDown.SelectedIndex > 0)
            {
                ProductsGridView.DataSource = _ProductManager.LookupProductsBySupplier(int.Parse(SuppliersDropDown.SelectedValue));
                ProductsGridView.DataBind();
            }
        }
    }
}