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
            if (DropDownList1.SelectedValue=="Male")
                gender = 0;
            else if (DropDownList1.SelectedValue=="Female")
                gender = 1;

            SqlCommand registerProc = new SqlCommand("studentRegister", conn);
            registerProc.CommandType = System.Data.CommandType.StoredProcedure;
            registerProc.Parameters.Add(new SqlParameter("@first_name",first));
            registerProc.Parameters.Add(new SqlParameter("@last_name", last));
            registerProc.Parameters.Add(new SqlParameter("@password", pass));
            registerProc.Parameters.Add(new SqlParameter("@email", mail));
            registerProc.Parameters.Add(new SqlParameter("@address", addr));
            registerProc.Parameters.Add(new SqlParameter("@gender", gender));
            SqlCommand getId = new SqlCommand("getId", conn);
            getId.CommandType = System.Data.CommandType.StoredProcedure;
            getId.Parameters.Add(new SqlParameter("@email", mail));
            SqlParameter sid = getId.Parameters.Add("@id", System.Data.SqlDbType.Int);
            sid.Direction = System.Data.ParameterDirection.Output;
            try
            {
                conn.Open();
                registerProc.ExecuteNonQuery();
                getId.ExecuteNonQuery();
                Session["user"] = sid.Value;
                Response.Redirect("StudentHome.aspx");
            }
            catch (Exception)
            {
                Label1.Text = "There is another account with this email !!";
            }
            finally {
                conn.Close();
            }
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
            if (DropDownList1.SelectedValue == "Male")
                gender = 0;
            else if (DropDownList1.SelectedValue == "Female")
                gender = 1;

            SqlCommand registerProc = new SqlCommand("InstructorRegister", conn);
            registerProc.CommandType = System.Data.CommandType.StoredProcedure;
            registerProc.Parameters.Add(new SqlParameter("@first_name", first));
            registerProc.Parameters.Add(new SqlParameter("@last_name", last));
            registerProc.Parameters.Add(new SqlParameter("@password", pass));
            registerProc.Parameters.Add(new SqlParameter("@email", mail));
            registerProc.Parameters.Add(new SqlParameter("@address", addr));
            registerProc.Parameters.Add(new SqlParameter("@gender", gender));
            SqlCommand getId = new SqlCommand("getId", conn);
            getId.CommandType = System.Data.CommandType.StoredProcedure;
            getId.Parameters.Add(new SqlParameter("@email", mail));
            SqlParameter sid = getId.Parameters.Add("@id", System.Data.SqlDbType.Int);
            sid.Direction = System.Data.ParameterDirection.Output;
            try
            {
                conn.Open();
                registerProc.ExecuteNonQuery();
                getId.ExecuteNonQuery();
                Session["user"] = sid.Value;
                Response.Redirect("InstructorHome.aspx");
            }
            catch (Exception)
            {
                Label1.Text = "There is another account with this email !!";
            }
            finally
            {
                conn.Close();
            }
        }

       

      

    }
}