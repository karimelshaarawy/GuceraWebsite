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
    public partial class AcceptCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Accept_Click(object sender, EventArgs e)
        {
            int adminID = 0;
            int CourseId = 0;
            try
            {
                adminID = (int)Session["user"];
                CourseId = Int16.Parse(Txt2.Text);
            }
            catch (Exception) { Label3.Text = "please enter correct information";return; }
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(connstr);
            SqlCommand AcceptCourse = new SqlCommand("AdminAcceptRejectCourse", conn);
            AcceptCourse.CommandType = CommandType.StoredProcedure;
            AcceptCourse.Parameters.Add(new SqlParameter("@admindid", adminID));
            AcceptCourse.Parameters.Add(new SqlParameter("@courseId", CourseId));
            conn.Open();
            AcceptCourse.ExecuteNonQuery();
            conn.Close();

        }
    }
}