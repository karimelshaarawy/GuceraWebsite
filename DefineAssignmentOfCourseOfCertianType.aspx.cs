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
    public partial class DefineAssignmentOfCourseOfCertianType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void defineAssigment_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);

            try
            {
                SqlCommand addCourseProc = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
                int id = (int)Session["user"];
                int cid = Int16.Parse(CourseID.Text);
                int number = Int16.Parse(num.Text);
                int fullgradeInt = Int16.Parse(fullgrade.Text);
                decimal weightInt = decimal.Parse(weight.Text);

                addCourseProc.CommandType = System.Data.CommandType.StoredProcedure;
                addCourseProc.Parameters.Add(new SqlParameter("@fullGrade", fullgradeInt));
                addCourseProc.Parameters.Add(new SqlParameter("@number", number));
                addCourseProc.Parameters.Add(new SqlParameter("@cid", cid));
                addCourseProc.Parameters.Add(new SqlParameter("@instId", id));
                addCourseProc.Parameters.Add(new SqlParameter("@deadline", deadline.Text));
                addCourseProc.Parameters.Add(new SqlParameter("@content", content.Text));
                addCourseProc.Parameters.Add(new SqlParameter("@type", type.Text));

                conn.Open();
                Label8.Text = "Assigment added successfully";
                addCourseProc.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Label8.Text = "Error happened";
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
                Label1.Text = err.Message;
            }
        }

    }
}