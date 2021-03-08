using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Sandbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitName_Click(object sender, EventArgs e)
        {
            MessageBox.Text = $"Hello {FirstName.Text}! Welcome to WebForms (aspx pages)!";
        }
    }
}