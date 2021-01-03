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
    public partial class CreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddCreditCard_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            int sid =(int) Session["user"];
            string cardNumber = number.Text;
            string holder = holderName.Text;
            String cv = cvv.Text;
            string expiryDate =date.Text;
            SqlCommand addCreditCard = new SqlCommand("addCreditCard", conn);
            addCreditCard.CommandType = CommandType.StoredProcedure;
            addCreditCard.Parameters.Add(new SqlParameter("@number", cardNumber));
            addCreditCard.Parameters.Add(new SqlParameter("@cardHolderName", holder));
            addCreditCard.Parameters.Add(new SqlParameter("@sid", sid));
            addCreditCard.Parameters.Add(new SqlParameter("@expiryDate", expiryDate));
            addCreditCard.Parameters.Add(new SqlParameter("@cvv", cv));

            try
            {
                conn.Open();
                addCreditCard.ExecuteNonQuery();
                conn.Close();
            }catch(Exception )
            {
                Response.Write("You have already added this credit card");
            }


        }
    }
}