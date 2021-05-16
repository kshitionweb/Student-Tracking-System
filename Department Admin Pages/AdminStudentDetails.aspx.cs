using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Tracking_System.Pages.Department_Admin_Pages
{
    public partial class AdminStudentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblStudent_id.Text = Request.QueryString["student_id"];
        }
    }
}