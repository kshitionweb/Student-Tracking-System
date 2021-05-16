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
    public partial class AdminAnnouncements : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            if (!Page.IsPostBack)
            {
                this.SearchEvents();
            }
        }
        private void SearchEvents()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string sql = "SELECT event_name, date_of_event, event_venue, event_image_name FROM Event_Table";
                if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                {
                    if (ddlEventSearch.SelectedItem.Value == "event_name")
                    {
                        sql += " WHERE event_name LIKE @event_name + '%'";
                        cmd.Parameters.AddWithValue("@event_name", txtSearch.Text.Trim());
                    }
                    else if (ddlEventSearch.SelectedItem.Value == "date_of_event")
                    {
                        sql += " WHERE date_of_event LIKE @date_of_event + '%'";
                        cmd.Parameters.AddWithValue("@date_of_event", txtSearch.Text.Trim());
                    }
                    else if (ddlEventSearch.SelectedItem.Value == "event_venue")
                    {
                        sql += " WHERE event_venue LIKE @event_venue + '%'";
                        cmd.Parameters.AddWithValue("@event_venue", txtSearch.Text.Trim());
                    }
                }
                cmd.CommandText = sql;
                cmd.Connection = conn;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    gridEventList.DataSource = dt;
                    gridEventList.DataBind();
                }
            }
        }

        protected void girdEventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string event_name = gridEventList.SelectedRow.Cells[2].Text;
            Response.Redirect("AdminEventDetails.aspx?event_name=" + event_name);
        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            gridEventList.PageIndex = e.NewPageIndex;
            this.SearchEvents();
        }

        protected void btnSearchEvent_Click(object sender, EventArgs e)
        {
            this.SearchEvents();
        }
    }
}