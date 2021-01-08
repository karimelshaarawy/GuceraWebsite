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
    public partial class view_assign_grade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewAssignmentGrade_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["gucera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);





            int cid = Int16.Parse(courseId.Text);
            string assignType = assignmentType.Text;
            int assignNumber = Int16.Parse(assignmentNumber.Text);
            int sid1 = (int)Session["user"];
            SqlCommand viewGrade = new SqlCommand("viewAssignGrades", conn);
            viewGrade.Parameters.Add(new SqlParameter("@assignType", assignType));
            viewGrade.Parameters.Add(new SqlParameter("@assignNumber", assignNumber));
            viewGrade.Parameters.Add(new SqlParameter("@cid", cid));
            viewGrade.Parameters.Add(new SqlParameter("@sid", sid1));
            SqlParameter assignGrade = viewGrade.Parameters.Add("@assignGrade", System.Data.SqlDbType.Int);
            assignGrade.Direction = System.Data.ParameterDirection.Output;
            viewGrade.CommandType = System.Data.CommandType.StoredProcedure;
            SqlCommand check = new SqlCommand("select COUNT(*) from StudentTakeAssignment STC inner join Course C on STC.cid=C.id inner join Assignment A on STC.assignmentNumber=A.number where STC.cid=@cid AND STC.sid=@sid AND C.id=@cid and A.type=@assignType AND A.number=@assignnumber", conn);
            check.Parameters.AddWithValue("@cid", courseId.Text);
            check.Parameters.AddWithValue("@sid",sid1);
            check.Parameters.AddWithValue("@assignType", assignmentType.Text);
            check.Parameters.AddWithValue("@assignNumber", assignmentNumber.Text);

            conn.Open();
            int result = (int)check.ExecuteScalar();





            if (result == 0)
                Response.Write("not enrolled in the course");
            else
            {
                viewGrade.ExecuteNonQuery();
                Response.Write(assignGrade.Value);
            }
            conn.Close();



        }
    }
}