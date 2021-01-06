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
    public partial class Promocode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(connstr);
            int id = (int)Session["user"];
            SqlCommand viewPromocodes = new SqlCommand("viewPromocode", conn);
            viewPromocodes.CommandType = CommandType.StoredProcedure;
            viewPromocodes.Parameters.Add(new SqlParameter("@sid", id));
            conn.Open();
            SqlDataReader rdr = viewPromocodes.ExecuteReader(CommandBehavior.CloseConnection);

            GridView1.DataSource = rdr;
            GridView1.DataBind();
        }
    }
}