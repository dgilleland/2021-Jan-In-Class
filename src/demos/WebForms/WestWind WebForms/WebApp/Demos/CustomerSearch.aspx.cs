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
    public partial class CustomerSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // GET Request
            {
                // Populate my drop-down with default data
                MatchingNames.Items.Add(new ListItem("[Select a customer]", string.Empty));
            }
            MessageLabel.Text = "";
        }

        protected void FindCustomers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PartialName.Text))
            {
                MessageLabel.Text = "Enter at least one character for the partial name.";
            }
            else
            {
                // Populate the Matching Names dropdown with data.
                // 1) Get information from the BLL
                var controller = new CustomerController();
                var customers = controller.LoadCustomers(PartialName.Text);

                // 2) Display the information in the drop-down control
                MatchingNames.DataSource = customers; // Telling the control what data to use
                MatchingNames.DataTextField = nameof(Customer.CompanyName); // Text to display for each item
                MatchingNames.DataValueField = nameof(Customer.CustomerID); // Value to use (PK of the customer)
                MatchingNames.DataBind(); // go ahead and extract the appropriate info from .DataSource to generate your HTML
                MatchingNames.Items.Insert(0, new ListItem("[Select a customer]", string.Empty));
            }
        }

        protected void ShowOrders_Click(object sender, EventArgs e)
        {
            // 0) Validation for ShowOrders
            if (MatchingNames.SelectedIndex == 0) // The first item, which is a "prompt" inside the <select> element
            {
                MessageLabel.Text = "You must select a customer to view their orders.";
            }
            else
            {
                // Navigate to the other page
                var customerId = MatchingNames.SelectedValue; // Grabbing the value for the selected item in the drop-down
                Response.Redirect($"~/Demos/ViewCustomerOrders.aspx?customerId={customerId}", true);
            }
        }
    }
}