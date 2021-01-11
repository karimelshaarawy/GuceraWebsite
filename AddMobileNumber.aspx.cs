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
    public partial class AddMobileNumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            String mobilePhone ="";
            String sid1 = "";
            try
            {
                mobilePhone = number.Text;
                sid1 = (Session["user"]).ToString();
            }
            catch (Exception)
            {
                Response.Write("Wrong Input");
                return;
            }
          
            SqlCommand addMobile = new SqlCommand("addMobile", conn);
            addMobile.CommandType = System.Data.CommandType.StoredProcedure;
            addMobile.Parameters.Add(new SqlParameter("@ID", sid1));
            addMobile.Parameters.Add(new SqlParameter("mobile_number", mobilePhone));
            try
            {
                conn.Open();
                addMobile.ExecuteNonQuery();
                Response.Write("Done");
            }
            catch (Exception)
            {
                Response.Write("Number Already exists");
                return;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}