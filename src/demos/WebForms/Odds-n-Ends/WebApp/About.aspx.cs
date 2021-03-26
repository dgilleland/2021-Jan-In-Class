using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class About : Page
    {
        // Faux-database - it gets wiped every time I change code & re-run the app.
        private static List<Apply> Applications = new List<Apply>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ApplyForJob_Click(object sender, EventArgs e)
        {
            // 0) Validation
            if (IsValid) // Ensure the validation controls run at the server-side
            {
                // 0b) - Don't allow any duplicate applications (unique emails)
                bool duplicateEmail = false;
                foreach(var person in Applications)
                    if(person.Email == YourEmail.Text)
                        duplicateEmail = true;

                if (!duplicateEmail)
                {
                    // 1) Extract the data from the form into an instance of my Apply class
                    var newApplication = new Apply
                    {
                        FullName = YourFullName.Text,
                        Email = YourEmail.Text
                    };
                    newApplication.Age = int.Parse(YourAge.Text);
                    newApplication.MinimumStartingSalary = decimal.Parse(YourMinStartingSalary.Text);
                    newApplication.ApplicationDate = DateTime.Now;
                    newApplication.Comment = "In Process";
                    if (newApplication.MinimumStartingSalary > 70000)
                    {
                        newApplication.Comment = "We can't afford you!";
                        newApplication.Rejected = true;
                    }
                    if (newApplication.Age < 18)
                    {
                        newApplication.Comment = "We don't do child labour.";
                        newApplication.Rejected = true;
                    }
                    if (newApplication.Age > 50)
                    {
                        newApplication.Comment = "We appreciate your experience, but we're ageist...";
                        newApplication.Rejected = true;
                    }


                    // 2) Update the GridView with data
                    Applications.Add(newApplication);
                    ApplicationsGridView.DataSource = Applications;
                    ApplicationsGridView.DataBind();
                }
            }
        }
    }
}