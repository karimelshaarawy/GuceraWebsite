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
    public partial class AddCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addCourse(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);

           
            
                SqlCommand addCourseProc = new SqlCommand("InstAddCourse", conn);
                int id = (int)Session["user"];
                int credit = Int16.Parse(Credit_hours.Text);
                decimal priceNum = Decimal.Parse(price.Text);
                addCourseProc.CommandType = System.Data.CommandType.StoredProcedure;
                addCourseProc.Parameters.Add(new SqlParameter("@creditHours", credit));
                addCourseProc.Parameters.Add(new SqlParameter("@name", Name.Text));
                addCourseProc.Parameters.Add(new SqlParameter("@price", priceNum));
                addCourseProc.Parameters.Add(new SqlParameter("@instructorId ", id));

                conn.Open();
                Label4.Text = "Course added succesfully";
                addCourseProc.ExecuteNonQuery();
            
           
                conn.Close();
           




        }
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                Label1.Text = err.Message;
            }
        }
    }
}