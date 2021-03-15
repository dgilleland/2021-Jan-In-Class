using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WestWindSystem.BLL;

namespace WebApp.Demos
{
    public partial class ViewCustomerOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // GET Request
            {
                // Retreive the customer and customer order information for the form
                // 1) Manually grab the querystring data
                string customerId = Request.QueryString[nameof(customerId)];

                // 2) Lookup the specfic customer details
                CustomerController controller = new CustomerController();
                var details = controller.FindCustomer(customerId);

                // 2a) Do a re-direct if we don't have this customer
                if (details == null)
                    Response.Redirect("~/Demos/CustomerSearch", true);

                // 3) Display those details in my form
                CustomerName.Text = details.CompanyName;
                ContactName.Text = details.ContactName;
                PhoneNumber.Text = details.Phone;

                // 4) Lookup the orders for this customer
                OrdersController ordController = new OrdersController();
                var orders = ordController.GetCustomerOrders(customerId);

                // 5) Display the orders in the GridView
                //    The GridView is a DataBound Control. Other DataBound controls include DropDownList, ListView, Repeater.
                OrdersGridView.DataSource = orders;
                OrdersGridView.DataBind();
            }
        }
    }
}