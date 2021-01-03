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
    public partial class viewAssignment : System.Web.UI.Page
    {
        private object viewAssign;
        private SqlCommand sqlcommand;

        public object GridView1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void courseID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void IDenter_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            int id = Int16.Parse(courseID.Text);
            int sid = (int)Session["user"];
            SqlCommand viewAssignProc = new SqlCommand("viewAssign", conn);
            viewAssignProc.Parameters.Add(new SqlParameter("@courseId",id));
            viewAssignProc.Parameters.Add(new SqlParameter("@Sid", sid));
            viewAssignProc.CommandType = CommandType.StoredProcedure;
            conn.Open();

            SqlDataReader rdr = viewAssignProc.ExecuteReader(CommandBehavior.CloseConnection);

            assignment.DataSource = rdr;
            assignment.DataBind();

        }
    }
}