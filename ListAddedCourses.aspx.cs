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
    public partial class ListAddedCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(connstr);
            SqlCommand viewAddedCourses = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            viewAddedCourses.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader rdr = viewAddedCourses.ExecuteReader(CommandBehavior.CloseConnection);

            table2.DataSource = rdr;
            table2.DataBind();
        }
    }
}