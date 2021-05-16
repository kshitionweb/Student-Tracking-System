using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Student_Tracking_System.Pages.Admin_Pages
{
    public partial class AdminChangePassword : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
                
            //}
        }

        protected void btnAdminChangePwd_Click(object sender, EventArgs e)
        {
            conn.Open();

            string update_admin_pwd = "update Admin_Table set admin_password = '" + txtAdminNewPwd.Text + "' where admin_id = '" + Session["AdminID"].ToString() + "' and admin_security_ans = '"+txtAdminSecAns.Text+"'";
            SqlCommand cmd = new SqlCommand(update_admin_pwd, conn);

            cmd.ExecuteNonQuery();
        }
    }
}