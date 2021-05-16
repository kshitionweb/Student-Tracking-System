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
    public partial class AdminAnnouncementDetails : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();

            string eventName = Request.QueryString["event_name"];

            if (!IsPostBack)
            {
                string fetchEvent = "select * from Event_Table where event_name='" + eventName + "'";
                SqlCommand cmd = new SqlCommand(fetchEvent, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    imgEventDetailImage.ImageUrl = sdr[5].ToString();

                    lblEventDetailHeading.Text = sdr[1].ToString();
                    lblEventDate.Text = sdr[2].ToString();
                    lblEventVenue.Text = sdr[3].ToString();
                    lblEventDetails.Text = sdr[4].ToString();
                }
                sdr.Close();
            }
            
        }

        protected void btnEventDelete_Click(object sender, EventArgs e)
        {
            string eventName = Request.QueryString["event_name"];

            string deleteEvent = "delete from Event_Table where event_name='" + eventName + "'";

            SqlCommand cmd = new SqlCommand(deleteEvent, conn);
            cmd.ExecuteNonQuery();
            Response.Redirect("AdminEvents.aspx");
        }

        protected void btnEventUpdate_Click(object sender, EventArgs e)
        {
            string eventName = Request.QueryString["event_name"];
            Response.Redirect("EventEditForm.aspx?event_name=" + eventName);
        }
    }
}