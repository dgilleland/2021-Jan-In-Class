using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = string.Empty;
        }

        protected void NumberSequenceDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageLabel.Text = $"You selected the number {NumberSequenceDropDown.SelectedValue} which was the {NumberSequenceDropDown.SelectedItem.Text} number in the drop-down.";
        }
    }
}