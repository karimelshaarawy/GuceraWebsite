using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace Gucera
{
    public partial class MyProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(connstr);
            SqlCommand profile = new SqlCommand("viewMyProfile", conn);
            int id = (int)Session["user"];
            profile.CommandType = System.Data.CommandType.StoredProcedure;
            profile.Parameters.Add(new SqlParameter("@id", id));
            conn.Open();
            SqlDataReader rdr = profile.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                int identity = rdr.GetInt32(rdr.GetOrdinal("id"));
                Label idd = new Label();
                idd.Text = "ID : " + identity + "<br>";
                form1.Controls.Add(idd);
                string firstname = rdr.GetString(rdr.GetOrdinal("firstName"));
                Label firstnamel = new Label();
                firstnamel.Text = "First Name : " + firstname + "<br>";
                form1.Controls.Add(firstnamel);

                string lastname = rdr.GetString(rdr.GetOrdinal("lastName"));
                Label lastnamel = new Label();
                lastnamel.Text = "Last Name : " + lastname + "<br>";
                form1.Controls.Add(lastnamel);

                string password = rdr.GetString(rdr.GetOrdinal("password"));
                Label passwordl = new Label();
                passwordl.Text = "Password : " + password + "<br>";
                form1.Controls.Add(passwordl);

                string email = rdr.GetString(rdr.GetOrdinal("email"));
                Label emaill = new Label();
                emaill.Text = "Email : " + email + "<br>";
                form1.Controls.Add(emaill);

                string address = rdr.GetString(rdr.GetOrdinal("address"));
                Label addressl = new Label();
                addressl.Text = "Adress : " + address + "<br>";
                form1.Controls.Add(addressl);

                Byte[] gender = (byte[])rdr.GetSqlBinary(rdr.GetOrdinal("gender"));
                Label genderl = new Label();
                string genderType;
                if (gender[0] == 0)
                    genderType = "Male";
                else if (gender[0] == 1)
                    genderType = "Female";
                else
                    genderType = "Not Declared";
                genderl.Text = "Gender : " + genderType + "<br>";
                form1.Controls.Add(genderl);

                decimal gpa = rdr.GetDecimal(rdr.GetOrdinal("gpa"));
                Label gpal = new Label();
                gpal.Text = "GPA : " + gpa + "<br>";
                form1.Controls.Add(gpal);
            }

        }
    }
}