using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Student_Tracking_System.Pages.Admin_Pages
{
    public partial class AdminStudentList : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            if (!Page.IsPostBack)
            {
                this.SearchStudents();
            }
        }
        private void SearchStudents()
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                string sql = "SELECT student_id, student_first_name, student_last_name, student_email, student_passout_year FROM Student_Table";
                if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
                    if (ddlStudentSearch.SelectedItem.Value == "student_id")
                    {
                        sql += " WHERE student_id LIKE @student_id + '%'";
                        cmd.Parameters.AddWithValue("@student_id", txtSearch.Text.Trim());
                    }
                    else if (ddlStudentSearch.SelectedItem.Value == "student_first_name")
                    {
                        sql += " WHERE student_first_name LIKE @student_first_name + '%'";
                        cmd.Parameters.AddWithValue("@student_first_name", txtSearch.Text.Trim());
                    }
                    else if (ddlStudentSearch.SelectedItem.Value == "student_last_name")
                    {
                        sql += " WHERE student_last_name LIKE @student_last_name + '%'";
                        cmd.Parameters.AddWithValue("@student_last_name", txtSearch.Text.Trim());
                    }
                    else if (ddlStudentSearch.SelectedItem.Value == "student_email")
                    {
                        sql += " WHERE student_email LIKE @student_email + '%'";
                        cmd.Parameters.AddWithValue("@student_email", txtSearch.Text.Trim());
                    }
                    else if (ddlStudentSearch.SelectedItem.Value == "student_passout_year")
                    {
                        sql += " WHERE student_passout_year LIKE @student_passout_year + '%'";
                        cmd.Parameters.AddWithValue("@student_passout_year", txtSearch.Text.Trim());
                    }
                }
                cmd.CommandText = sql;
                cmd.Connection = conn;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    gvStudentSearch.DataSource = dt;
                    gvStudentSearch.DataBind();
                }
            }
        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            gvStudentSearch.PageIndex = e.NewPageIndex;
            this.SearchStudents();
        }


        protected void btnSearchStudent_Click(object sender, EventArgs e)
        {
            this.SearchStudents();
        }

        protected void gvStudentSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string student_id = gvStudentSearch.SelectedRow.Cells[1].Text;
            Response.Redirect("AdminStudentDetails.aspx?student_id=" + student_id);
        }
    }
}