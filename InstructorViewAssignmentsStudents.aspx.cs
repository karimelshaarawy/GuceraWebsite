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
    public partial class InstructorViewAssignmentsStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showTable_Click(object sender, EventArgs e)
        {
          
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(connstr);
            SqlCommand availableCourses = new SqlCommand("InstructorViewAssignmentsStudents", conn);
            int id = (int)Session["user"];
            try
            {
                availableCourses.Parameters.Add(new SqlParameter("@cid", Int16.Parse(CourseID.Text)));
                availableCourses.Parameters.Add(new SqlParameter("@instrId", id));
                availableCourses.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader rdr = availableCourses.ExecuteReader(CommandBehavior.CloseConnection);

                Assigment.DataSource = rdr;
                Assigment.DataBind();
            }
            catch(Exception)
            {
                Label2.Text = "error occured invalid input";
            }

        }
    }
}