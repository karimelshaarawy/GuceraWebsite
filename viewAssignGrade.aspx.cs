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
            int sid = (int)Session["user"];
            SqlCommand viewGrade = new SqlCommand("viewAssignGrades", conn);
            viewGrade.Parameters.Add(new SqlParameter("@assignType", assignType));
            viewGrade.Parameters.Add(new SqlParameter("@assignNumber", assignNumber));
            viewGrade.Parameters.Add(new SqlParameter("@cid", cid));
            viewGrade.Parameters.Add(new SqlParameter("@sid", sid));
            SqlParameter assignGrade = viewGrade.Parameters.Add("@assignGrade", System.Data.SqlDbType.Int);
            assignGrade.Direction = System.Data.ParameterDirection.Output;
            viewGrade.CommandType = System.Data.CommandType.StoredProcedure;

        }
    }
}