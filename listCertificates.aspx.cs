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
    public partial class listCertificates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
            int cid1 = 0;
            try
            {
                 cid1 = Int16.Parse(courseId.Text);
            }
            catch (Exception)
            {
                Response.Write("Wrong Input");
                return;
            }
            int sid1 = (int)Session["user"];
            SqlCommand viewCertificate = new SqlCommand("viewCertificate", conn);
                 viewCertificate.Parameters.Add(new SqlParameter("@cid", cid1));
            viewCertificate.Parameters.Add(new SqlParameter("@sid", sid1));
            viewCertificate.CommandType = System.Data.CommandType.StoredProcedure ;

            conn.Open();
            Label2.Text = "";
            SqlDataReader rdr = viewCertificate.ExecuteReader(CommandBehavior.CloseConnection);

            GridView1.DataSource = rdr;
            GridView1.DataBind();
        }
        protected void OnInfoMessage(
object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                Label2.Text = err.Message;
            }
        }
    }
}

