using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gucera
{
    public partial class InstructorViewAcceptedCoursesByAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(connstr);
            SqlCommand availableCourses = new SqlCommand("InstructorViewAcceptedCoursesByAdmin", conn);
            availableCourses.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader rdr = availableCourses.ExecuteReader(CommandBehavior.CloseConnection);

            AcceptedCourses.DataSource = rdr;
            AcceptedCourses.DataBind();
        }
    }
}