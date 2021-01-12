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
    public partial class CreatePromoCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void create_Click(object sender, EventArgs e)
        {

            string promoCode = "";
            string isuue = "";
            string expiry = "";
            decimal disc = 0;
            int id = 0;
            try
            {
                promoCode = Txt1.Text;
                isuue = Txt2.Text;
                expiry = Txt3.Text;
                disc = decimal.Parse(Txt4.Text);
                id = Int16.Parse(Txt5.Text);
            }
            catch (Exception) { Label1.Text = "please enter promocode information correctly";return; }
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(connstr);
            SqlCommand CreatePromoCode = new SqlCommand("AdminCreatePromoCode", conn);
            CreatePromoCode.CommandType = CommandType.StoredProcedure;
            CreatePromoCode.Parameters.Add(new SqlParameter("@code", promoCode));
            CreatePromoCode.Parameters.Add(new SqlParameter("@isuueDate", isuue));
            CreatePromoCode.Parameters.Add(new SqlParameter("@expiryDate", expiry));
            CreatePromoCode.Parameters.Add(new SqlParameter("@discount", disc));
            CreatePromoCode.Parameters.Add(new SqlParameter("@adminId", id));
            try
            {
                conn.Open();
                CreatePromoCode.ExecuteNonQuery();
                Label1.Text = "PromoCode Created";
            }
            catch (Exception) { Label1.Text = "error creating promocode!"; }
            finally
            {
                conn.Close();
            }



        }
    }
}