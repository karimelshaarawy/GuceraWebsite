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
    public partial class EnrollInCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enroll_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
            try
            {
                int id = (int)Session["user"];
                int course = Int16.Parse(cid.Text);
                int instructor = Int16.Parse(instid.Text);
                SqlCommand enroll = new SqlCommand("enrollInCourse", conn);
                enroll.CommandType = CommandType.StoredProcedure;
                enroll.Parameters.Add(new SqlParameter("@sid", id));
                enroll.Parameters.Add(new SqlParameter("@cid", course));
                enroll.Parameters.Add(new SqlParameter("@instr", instructor));
                conn.Open();
                Label1.Text = "you have enrolled in this course successfully";
                enroll.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                Label1.Text = "Invalid Input or you have already enorlled in this course";
            }
            finally {
                conn.Close();
            }
        }
        protected void OnInfoMessage(
  object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                Label1.Text = err.Message;
            }
        }
    }
}