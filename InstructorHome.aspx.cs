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
            Response.Redirect("AddCourse.aspx");
        }


        protected void define_assigment_Click(object sender, EventArgs e)
        {
            Response.Redirect("DefineAssignmentOfCourseOfCertianType.aspx");

        }

        protected void view_assigment_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewAssignment.aspx");

        }

        protected void grade_assigment_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorgradeAssignmentOfAStudent.aspx");
        }

        protected void view_feedback_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewFeedbacksAddedByStudentsOnMyCourse.aspx");
        }

        protected void issue_certificate_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorIssueCertificateToStudent.aspx");
        }

        protected void add_num_Click(object sender, EventArgs e)
        {
            Response.Redirect("addMobileNumber.aspx");

        }
    }
}