using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AdHocGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theCourse = AdHocGridView.SelectedValue.ToString(); // This is getting the Number of the course

            MessageLabel.Text = $"You credit redemption for course {theCourse} will be processed within 5 business days. If you are successful, then you will be contacted by a CSIS agent to be interviewed as part of our Cyber-Security Task Force.";
        }
    }
}