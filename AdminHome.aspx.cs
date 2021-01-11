using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gucera
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListAllCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListAllCourses.aspx");
        }

        protected void ListAllNonAcceptedCourses_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListAddedCourses.aspx");
        }

        protected void AcceptCourses_Click(object sender, EventArgs e)
        {
            Response.Redirect("AcceptCourses.aspx");
        }

        protected void CreatePromoCode_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreatePromoCode.aspx");
        }

        protected void IssuePromoCode_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssuePromoCode.aspx");
        }
    }
}