using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WestWindSystem.BLL;

namespace WebApp.Demos
{
    public partial class ManageOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) // GET Request
            {
                // Populate the various DropDownList controls with data
                PopulateEmployeeDropDown();
                PopulateCustomerDropDown();
                PopulateAddressDropDown();
                // Check if I am starting with an existing order (from the querystring)
                LoadSpecificOrder();
            }
        }

        private void LoadSpecificOrder()
        {
            // Checking the querystring
            int orderId;
            if(int.TryParse(Request.QueryString[nameof(orderId)], out orderId))
            {
                OrdersController controller = new OrdersController();
                var order = controller.GetOrder(orderId);
                if(order != null)
                {
                    // Populate the form with the data
                    OrderId.Text = order.OrderID.ToString();
                    Freight.Text = order.Freight.ToString();
                    Comments.Text = order.Comments;
                    ShipName.Text = order.ShipName;
                    if (order.OrderDate.HasValue)
                        OrderDate.Text = order.OrderDate.Value.ToString("yyyy-MM-dd");
                    if (order.RequiredDate.HasValue)
                        RequiredDate.Text = order.RequiredDate.Value.ToString("yyyy-MM-dd");
                    if (order.PaymentDueDate.HasValue)
                        PaymentDueDate.Text = order.PaymentDueDate.Value.ToString("yyyy-MM-dd");
                    Shipped.Checked = order.Shipped;

                    if (order.SalesRepID.HasValue)
                        SalesRep.SelectedValue = order.SalesRepID.ToString();
                    Customer.SelectedValue = order.CustomerID;
                    if (order.ShipAddressID.HasValue)
                        ShipAddress.SelectedValue = order.ShipAddressID.ToString();
                }
            }
        }

        void PopulateEmployeeDropDown()
        {
            EmployeeController controller = new EmployeeController();
            SalesRep.DataSource = controller.ListEmployees();
            SalesRep.DataTextField = nameof(WestWindSystem.Entities.Employee.FullName);
            SalesRep.DataValueField = nameof(WestWindSystem.Entities.Employee.EmployeeID);
            SalesRep.DataBind();
            SalesRep.Items.Insert(0, new ListItem("[Select an Employee]", ""));
        }

        void PopulateCustomerDropDown()
        {
            CustomerController controller = new CustomerController();
            Customer.DataSource = controller.ListAllCustomers();
            Customer.DataTextField = nameof(WestWindSystem.Entities.Customer.CompanyName);
            Customer.DataValueField = nameof(WestWindSystem.Entities.Customer.CustomerID);
            Customer.DataBind();
            Customer.Items.Insert(0, new ListItem("[Select a Customer]", ""));
        }

        void PopulateAddressDropDown()
        {
            AddressController controller = new AddressController();
            ShipAddress.DataSource = controller.ListAllAddresses();
            ShipAddress.DataTextField = nameof(WestWindSystem.Entities.Address.AbbreviatedAddress);
            ShipAddress.DataValueField = nameof(WestWindSystem.Entities.Address.AddressID);
            ShipAddress.DataBind();
            ShipAddress.Items.Insert(0, new ListItem("[Select an Address]", ""));
        }
    }
}