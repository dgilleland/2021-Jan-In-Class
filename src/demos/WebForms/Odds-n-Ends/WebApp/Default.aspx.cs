using MyBackendServices.BLL;
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
            if(!IsPostBack)
            {
                var controller = new FakeData();
                var data = controller.ListFishThings();
                FishGridView.DataSource = data;
                FishGridView.DataBind();
            }
        }

        protected void AdHocGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theCourse = AdHocGridView.SelectedValue.ToString(); // This is getting the Number of the course
            string citizenship = CitizenshipList.SelectedValue;
            string studyMajor = StudyProgramList.SelectedValue;

            string alertStyle = "alert ";
            string msg;
            if(string.IsNullOrEmpty(citizenship) || string.IsNullOrEmpty(studyMajor))
            {
                msg = "You should specify your citizenship and study major to get your credit redemption.";
                alertStyle += "alert-warning";
            }
            else
            {
                msg = $"You credit redemption for course {theCourse} will be processed within 5 business days. If you are successful, then you will be contacted by a CSIS agent to be interviewed as part of our Cyber-Security Task Force.";
                if(!bool.Parse(citizenship))
                {
                    msg += "<br />Preference is given to Canadian Citizens.";
                }
                alertStyle += "alert-success";
            }

            MessageLabel.Text = msg;
            MessageContainer.Attributes.Add("class", alertStyle);
        }
    }
}