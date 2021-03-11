using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WestWindSystem.BLL;

namespace WebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // this method will run on every request from the browser, regardless of whether it's a POST or a GET request.
            // We can check to see if it is a post using one of the properties that we inherit from the Page class.
            if (!IsPostBack) // if this is a GET request, which should be the first request of the page
            {
                // Grab the database verson.
                var controller = new DatabaseInfoController();
                //               \  DatabaseInfoController  /
                var info = controller.GetBuildVersion();
                //                    \ BuildVersion  /
                // Put that information into my label control
                DbVersionLabel.Text = info.ToString();
            }
        }
    }
}