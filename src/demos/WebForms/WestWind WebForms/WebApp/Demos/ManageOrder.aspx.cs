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
            MessageLabel.Text = string.Empty;
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

        // Our <asp:LinkButton> and <asp:Button> controls on our form have a OnClick event that will cause
        // the browser to submit the form. Our markup associates the name of our method (below) with the click event.
        protected void ClearForm_Click(object sender, EventArgs e)
        {
            // Clearing out the Textbox controls
            OrderId.Text = string.Empty; // I like using string.Empty because it's a little more explcit
            Freight.Text = string.Empty;
            // btw, I can basically "chain" a bunch of assignment statements
            Comments.Text = ShipName.Text = OrderDate.Text = RequiredDate.Text = PaymentDueDate.Text = string.Empty;

            // Clear the CheckBox control
            Shipped.Checked = false;

            // Clear the DropDownList controls
            Customer.SelectedIndex = -1; // No item in the list
            SalesRep.SelectedIndex = -1;
            ShipAddress.SelectedIndex = -1;
        }

        protected void UpdateOrder_Click(object sender, EventArgs e)
        {
            int id = 0;
            // 0) Perform basic server-side validation
            if (IsValid && int.TryParse(OrderId.Text, out id)) // IsValid is going to run the validation controls on the server-side
            {
                try
                {
                    // 1) Bundle the data into an Order object
                    var item = BundleOrderData();
                    item.OrderID = id;

                    // 2) Send the object to the BLL for processing
                    var controller = new OrdersController();
                    controller.UpdateOrder(item);

                    // 3) Give feedback to the user
                    MessageLabel.Text = $"Order information updated for order {OrderId.Text}";
                }
                catch (Exception ex)
                {
                    string details = GetInnerExeceptionDetails(ex);
                    MessageLabel.Text = $"There was a problem processing the update: {details}";
                }
            }
            else
            {
                if (id == 0)
                    MessageLabel.Text = "You must have an existing order before you can update";
                else
                    MessageLabel.Text = "Please fill out required information before processing.";
            }
        }

        protected void AddOrder_Click(object sender, EventArgs e)
        {
            if (IsValid) // Checks the validation controls on the server-side
            {
                try
                {
                    // 1) Bundle the data into an Order object
                    var item = BundleOrderData();

                    // 2) Send the object to the BLL for processing
                    var controller = new OrdersController();
                    int id = controller.AddOrder(item);

                    // 3) Give feedback to the user
                    MessageLabel.Text = $"New Order generated with {id}";
                    OrderId.Text = id.ToString();
                }
                catch (Exception ex)
                {
                    string details = GetInnerExeceptionDetails(ex);
                    MessageLabel.Text = $"There was a problem processing the add: {details}";
                }
            }
        }

        private WestWindSystem.Entities.Order BundleOrderData()
        {
            return new WestWindSystem.Entities.Order
            {
                //OrderID = int.Parse(OrderId.Text),
                Freight = Freight.Text.ToNullableDecimal(),
                Comments = Comments.Text,
                ShipName = ShipName.Text,
                OrderDate = OrderDate.Text.ToNullableDateTime(),
                RequiredDate = RequiredDate.Text.ToNullableDateTime(),
                PaymentDueDate = PaymentDueDate.Text.ToNullableDateTime(),
                Shipped = Shipped.Checked,
                CustomerID = Customer.SelectedValue,
                SalesRepID = SalesRep.SelectedValue.ToNullableInt(),
                ShipAddressID = ShipAddress.SelectedValue.ToNullableInt()
            };
        }

        protected void DeleteOrder_Click(object sender, EventArgs e)
        {
            int id;
            // 1) Identify the order
            if (int.TryParse(OrderId.Text, out id))
            {
                try
                {
                    // 2) Send the data to the BLL for processing
                    var controller = new OrdersController();
                    controller.DeleteOrder(id);
                    // 3) Give feedback to the user
                    MessageLabel.Text = $"The order was deleted.";
                    ClearForm_Click(sender, e); // Re-use this clear method.
                }
                catch (Exception ex)
                {
                    string details = GetInnerExeceptionDetails(ex);
                    MessageLabel.Text = $"There was a problem in deleting the order: {details}";
                }
            }
            else
            {
                MessageLabel.Text = "You can only delete an existing order.";
            }
        }

        private string GetInnerExeceptionDetails(Exception ex)
        {
            Exception current = ex;
            while (current.InnerException != null)
                current = current.InnerException;
            return current.Message;
        }
    }
}