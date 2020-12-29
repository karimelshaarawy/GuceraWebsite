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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void male_CheckedChanged(object sender, EventArgs e)
        {
            if (male.Checked == true)
                female.Checked = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void studentRegister(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            string first = firstName.Text;
            string last = lastName.Text;
            string pass = password.Text;
            string mail = email.Text;
            string addr = Address.Text;
            int gender=0;
            if (male.Checked)
                gender = 0;
            else if (female.Checked)
                gender = 1;

            SqlCommand registerProc = new SqlCommand("studentRegister", conn);
            registerProc.CommandType = System.Data.CommandType.StoredProcedure;
            registerProc.Parameters.Add(new SqlParameter("@first_name",first));
            registerProc.Parameters.Add(new SqlParameter("@last_name", last));
            registerProc.Parameters.Add(new SqlParameter("@password", pass));
            registerProc.Parameters.Add(new SqlParameter("@email", mail));
            registerProc.Parameters.Add(new SqlParameter("@address", addr));
            registerProc.Parameters.Add(new SqlParameter("@gender", gender));
            conn.Open();
            registerProc.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("StudentHome.aspx");
        }


        protected void InstructorRegister(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            string first = firstName.Text;
            string last = lastName.Text;
            string pass = password.Text;
            string mail = email.Text;
            string addr = Address.Text;
            int gender = 0;
            if (male.Checked)
                gender = 0;
            else if (female.Checked)
                gender = 1;

            SqlCommand registerProc = new SqlCommand("InstructorRegister", conn);
            registerProc.CommandType = System.Data.CommandType.StoredProcedure;
            registerProc.Parameters.Add(new SqlParameter("@first_name", first));
            registerProc.Parameters.Add(new SqlParameter("@last_name", last));
            registerProc.Parameters.Add(new SqlParameter("@password", pass));
            registerProc.Parameters.Add(new SqlParameter("@email", mail));
            registerProc.Parameters.Add(new SqlParameter("@address", addr));
            registerProc.Parameters.Add(new SqlParameter("@gender", gender));
            conn.Open();
            registerProc.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("InstructorHome.aspx");
        }

       

        protected void female_CheckedChanged(object sender, EventArgs e)
        { if (female.Checked == true)
                male.Checked = false;

        }

    }
}