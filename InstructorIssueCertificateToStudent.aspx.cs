using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gucera
{
    public partial class InstructorIssueCertificateToStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Issue_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
            try
            {
                SqlCommand updateCourseProc = new SqlCommand("AddAnotherInstructorToCourse", conn);
                int id = (int)Session["user"];
                int cid = Int16.Parse(CourseID.Text);
                int sid = Int16.Parse(StudentID.Text);
                DateTime date = DateTime.Today;
                updateCourseProc.CommandType = System.Data.CommandType.StoredProcedure;
                updateCourseProc.Parameters.Add(new SqlParameter("@insId", id));
                updateCourseProc.Parameters.Add(new SqlParameter("@sid", sid));
                updateCourseProc.Parameters.Add(new SqlParameter("@cid", cid));
                updateCourseProc.Parameters.Add(new SqlParameter("@issueDate",date.ToString()));
                conn.Open();
                Label3.Text = "Course content updated succesfully";
                updateCourseProc.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Label3.Text = "Error occured : invalid input";
            }
            finally
            {
                conn.Close();
            }
        }
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                Label3.Text = err.Message;
            }
        }

    }
}