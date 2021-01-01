using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Gucera
{
    public partial class StudentHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewMyProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyProfile.aspx");
            
        }

        protected void viewAvailableCourses_Click(object sender, EventArgs e)
        {
            Response.Redirect("AvailableCourses.aspx");
        }

        protected void addCreditCard_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreditCard.aspx");
        }
    }
}