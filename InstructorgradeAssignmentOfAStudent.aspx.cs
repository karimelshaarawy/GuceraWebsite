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
    public partial class InstructorgradeAssignmentOfAStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grade_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);


            try
            {
                SqlCommand gradeAssigmentProc = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
                int id = (int)Session["user"];
                int cid = Int16.Parse(CourseId.Text);
                int sid = Int16.Parse(StudentId.Text);
                int assigmentNum = Int16.Parse(assigmentNumber.Text);
                decimal grade = Decimal.Parse(gradeNum.Text);
                gradeAssigmentProc.CommandType = System.Data.CommandType.StoredProcedure;
                gradeAssigmentProc.Parameters.Add(new SqlParameter("@cid", cid));
                gradeAssigmentProc.Parameters.Add(new SqlParameter("@sid", sid));
                gradeAssigmentProc.Parameters.Add(new SqlParameter("@assignmentNumber", assigmentNum));
                gradeAssigmentProc.Parameters.Add(new SqlParameter("@type", assigmentType.Text));
                gradeAssigmentProc.Parameters.Add(new SqlParameter("@grade", grade));
                gradeAssigmentProc.Parameters.Add(new SqlParameter("@instrId", id));
                conn.Open();
                Label6.Text = "Course added succesfully";
                gradeAssigmentProc.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Label6.Text = "Error invalid  input";
            }
            finally
            {
                conn.Close();
            }
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