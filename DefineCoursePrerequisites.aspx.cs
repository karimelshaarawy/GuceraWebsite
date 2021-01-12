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
    public partial class DefineCoursePrerequisites : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addPreq_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
            try
            {
                SqlCommand updateCourseProc = new SqlCommand("DefineCoursePrerequisites", conn);
                int cid = Int16.Parse(CourseId.Text);
                int preqIdInt = Int16.Parse(preqID.Text);

                updateCourseProc.CommandType = System.Data.CommandType.StoredProcedure;
                updateCourseProc.Parameters.Add(new SqlParameter("@cid", cid));
                updateCourseProc.Parameters.Add(new SqlParameter("@prerequsiteId", preqIdInt));
                conn.Open();
                Label3.Text = "Course prequisite added succesfully";
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