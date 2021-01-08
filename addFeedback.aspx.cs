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
    public partial class addFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            int cid1 = Int16.Parse(courseId.Text);
            String comment1 = comment.Text;
            int sid1 = (int)Session["user"];
            SqlCommand addFeed = new SqlCommand("addFeedback", conn);
            addFeed.Parameters.Add(new SqlParameter("@comment", comment1));
            addFeed.Parameters.Add(new SqlParameter("@cid", cid1));
            addFeed.Parameters.Add(new SqlParameter("@sid", sid1));
            addFeed.CommandType = System.Data.CommandType.StoredProcedure;
            SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM StudentTakeCourse WHERE sid = @sid AND cid = @cid", conn);
           
            check.Parameters.AddWithValue("@cid", courseId.Text);
            check.Parameters.AddWithValue("@sid", sid1);
            conn.Open();
            int result = (int)check.ExecuteScalar();





            if (result == 0)
                Response.Write("not enrolled in the course");
            else
                addFeed.ExecuteNonQuery();

            conn.Close();


        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}