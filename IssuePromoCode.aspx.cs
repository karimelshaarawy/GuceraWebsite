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
    public partial class IssuePromoCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Issue_Click(object sender, EventArgs e)
        {
            int studentid = 0;
            string promoid = "";
            try
            {
                studentid = Int16.Parse(Txt1.Text);
                promoid = Txt2.Text;
            }
            catch (Exception) { Label3.Text = "please enter correct information";return; }
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(connstr);
            SqlCommand IssuePromoCode = new SqlCommand("AdminIssuePromocodeToStudent", conn);
            IssuePromoCode.CommandType = CommandType.StoredProcedure;
            IssuePromoCode.Parameters.Add(new SqlParameter("@sid", studentid));
            IssuePromoCode.Parameters.Add(new SqlParameter("@pid", promoid));
            try
            {
                conn.Open();
                IssuePromoCode.ExecuteNonQuery();
                Label1.Text = "PromoCode Issued";
            }
            catch (Exception) { Label1.Text = "cannot issue promocode!"; }
            finally
            {
                conn.Close();
            }
        }

    }
}