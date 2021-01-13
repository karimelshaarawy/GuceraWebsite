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
    public partial class ViewFeedbacksAddedByStudentsOnMyCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void View_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);

            int cid = Int16.Parse(CourseId.Text);
            int instId = (int)Session["user"];
            try
            {
                SqlCommand viewAssignProc = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse ", conn);
                viewAssignProc.Parameters.Add(new SqlParameter("@cid", cid));
                viewAssignProc.Parameters.Add(new SqlParameter("@instrId", instId));
                viewAssignProc.CommandType = CommandType.StoredProcedure;
                conn.Open();

                SqlDataReader rdr = viewAssignProc.ExecuteReader(CommandBehavior.CloseConnection);

                Feedback.DataSource = rdr;
                Feedback.DataBind();
            }
            catch(Exception)
            {
                Label2.Text = "Error:invalid input";
            }


        }
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                Label2.Text = err.Message;
            }
        }

    }
}