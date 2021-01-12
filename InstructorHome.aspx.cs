using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gucera
{
    public partial class InstructorHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addCourse_click(object sender, EventArgs e)
        {
            Response.Redirect("AddCourse");
        }


        protected void define_assigment_Click(object sender, EventArgs e)
        {
            Response.Redirect("DefineAssignmentOfCourseOfCertianType");

        }

        protected void view_assigment_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewAssignment");

        }

        protected void grade_assigment_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorgradeAssignmentOfAStudent");
        }

        protected void view_feedback_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewFeedbacksAddedByStudentsOnMyCourse");
        }

        protected void issue_certificate_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorgradeAssignmentOfAStudent");
        }
    }
}