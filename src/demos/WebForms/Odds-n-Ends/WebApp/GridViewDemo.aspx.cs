using MyBackendServices.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class GridViewDemo : System.Web.UI.Page
    {
        private FakeData _Controller = new FakeData();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateRadioButtonList();
                PopulateGridView();
            }
        }

        private void PopulateRadioButtonList()
        {
            var studyMajors = _Controller.ListStudyPrograms();
            studyMajors.Insert(0, new StudyProgram { ProgramId = 0, Name = "All" });
            StudyProgramList.DataSource = studyMajors;
            StudyProgramList.DataTextField = nameof(StudyProgram.Name);
            StudyProgramList.DataValueField = nameof(StudyProgram.ProgramId);
            StudyProgramList.DataBind();
            StudyProgramList.SelectedValue = "0";
        }

        void PopulateGridView()
        {
            var data = _Controller.ListCourseMarks(int.Parse(StudyProgramList.SelectedValue));
            AdHocGridView.DataSource = data;
            AdHocGridView.DataBind();
        }

        protected void StudyProgramList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdHocGridView.PageIndex = 0;
            PopulateGridView();
        }

        protected void AdHocGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            AdHocGridView.PageIndex = e.NewPageIndex;
            PopulateGridView();
        }
    }
}