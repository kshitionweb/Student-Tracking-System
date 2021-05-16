using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Student_Tracking_System.Pages.Department_Admin_Pages
{
    public partial class EventEditForm : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string eventName = Request.QueryString["event_name"];

                conn.Open();
                string event_details = "select * from Event_Table where event_name='" + eventName + "'";
                SqlCommand cmd = new SqlCommand(event_details, conn);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    txtUploadEventName.Text = sdr[1].ToString();
                    txtUploadEventDate.Text = sdr[2].ToString();
                    txtUploadEventVenue.Text = sdr[3].ToString();
                    txtUploadEventDetails.Text = sdr[4].ToString();
                    imgEditImage.ImageUrl = sdr[5].ToString();
                }
                sdr.Close();
            }
        }

        protected void btnUpdateEventDetails_Click(object sender, EventArgs e)
        {
            conn.Open();

            string eventName = Request.QueryString["event_name"];

            if (fuUpdateEventImg.HasFile)
            {
                string fileName = fuUpdateEventImg.PostedFile.FileName;

                fuUpdateEventImg.SaveAs(Server.MapPath(@"~/EventImages/" + fileName));
                //imgEditImage.ImageUrl = "~/EventImages/" + fileName;

                string update_event_details = "update Event_Table set event_name = '" + txtUploadEventName.Text + "', date_of_event = '" + txtUploadEventDate.Text + "' , event_venue = '" + txtUploadEventVenue.Text + "', event_details = '" + txtUploadEventDetails.Text + "', event_image_name = '" + fileName + "' where event_name = '" + eventName + "'";
                SqlCommand cmd = new SqlCommand(update_event_details, conn);

                cmd.ExecuteNonQuery();
            }
            else
            {
                string update_event_details = "update Event_Table set event_name = '" + txtUploadEventName.Text + "', date_of_event = '" + txtUploadEventDate.Text + "' , event_venue = '" + txtUploadEventVenue.Text + "', event_details = '" + txtUploadEventDetails.Text + "' where event_name = '" + eventName + "'";
                SqlCommand cmd = new SqlCommand(update_event_details, conn);

                cmd.ExecuteNonQuery();
            }
            Response.Redirect("AdminEvents.aspx");
        }
    }
}