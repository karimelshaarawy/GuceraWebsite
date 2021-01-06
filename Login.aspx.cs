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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            int id =0;
            string pass="";
            try
            {
                 id = Int16.Parse(username.Text);
                 pass = password.Text;
            }
            catch (Exception) { Label1.Text = "Wrong username or password "; return; }
            SqlCommand loginProc = new SqlCommand("userlogin", conn);
            loginProc.CommandType = System.Data.CommandType.StoredProcedure;
            loginProc.Parameters.Add(new SqlParameter("@id", id));
            loginProc.Parameters.Add(new SqlParameter("@password", pass));
            SqlParameter success = loginProc.Parameters.Add("@Success", System.Data.SqlDbType.Int);
            SqlParameter type = loginProc.Parameters.Add("@type", System.Data.SqlDbType.Int);
            success.Direction = System.Data.ParameterDirection.Output;
            type.Direction = System.Data.ParameterDirection.Output;
            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();
            if (success.Value.ToString() == "1")
            {
                Session["user"] = id;
                if (type.Value.ToString() == "2")
                    Response.Redirect("StudentHome.aspx");
                else if (type.Value.ToString() == "0")
                    Response.Redirect("InstructorHome.aspx");
                else
                    Response.Redirect("AdminHome.aspx");
            }
            else
            {
                Label1.Text= "Wrong username or password ";
            }


        }
    }
}