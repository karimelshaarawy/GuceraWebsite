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
    public partial class submitAssign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void submitAssignment_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            int cid = Int16.Parse(courseId.Text);
            string assignType = assignmentType.Text;
            int assignNumber = Int16.Parse(assignmentNumber.Text);
            int sid = (int)Session["user"];
            SqlCommand submitproc = new SqlCommand("submitAssign", conn);
            submitproc.Parameters.Add(new SqlParameter("@assignType",assignType));
            submitproc.Parameters.Add(new SqlParameter("@assignNumber",assignNumber));
            submitproc.Parameters.Add(new SqlParameter("@cid",cid));
            submitproc.Parameters.Add(new SqlParameter("@sid",sid));
            submitproc.CommandType = CommandType.StoredProcedure;
            conn.Open();
            submitproc.ExecuteNonQuery();
            conn.Close();

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            int cid = Int16.Parse(courseId.Text);
            string assignType = assignmentType.Text;
            int assignNumber = Int16.Parse(assignmentNumber.Text);
            int sid = (int)Session["user"];
            SqlCommand submitproc = new SqlCommand("submitAssign", conn);
            submitproc.Parameters.Add(new SqlParameter("@assignType", assignType));
            submitproc.Parameters.Add(new SqlParameter("@assignNumber", assignNumber));
            submitproc.Parameters.Add(new SqlParameter("@cid", cid));
            submitproc.Parameters.Add(new SqlParameter("@sid", sid));
            submitproc.CommandType = CommandType.StoredProcedure;
            conn.Open();
            submitproc.ExecuteNonQuery();
            conn.Close();

        }
    }
}