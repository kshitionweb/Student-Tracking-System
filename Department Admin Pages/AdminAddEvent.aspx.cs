using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace Student_Tracking_System.Pages.Department_Admin_Pages
{
    public partial class AdminAddEvent : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            if (!IsPostBack)
            {
            }
        }

        protected void btnSubmitEventDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (fuEventImgUpload.HasFile)
                {
                    string fileExt = Path.GetExtension(fuEventImgUpload.PostedFile.FileName);
                    if (fileExt != ".JPEG" && fileExt != ".jpeg" && fileExt != ".JPG" && fileExt != ".jpg" && fileExt != ".png" && fileExt != ".tif" && fileExt != ".tiff")
                    {
                        Page.ClientScript.RegisterStartupScript(typeof(Page), "successfull", "alert('Please upload only jpeg, jpg, png, tif, tiff'); window.location = 'AdminAddEvent.aspx';", true);
                    }
                    else
                    {
                        string fileName = Path.GetFileName(fuEventImgUpload.FileName);

                        fuEventImgUpload.SaveAs(Server.MapPath("~/EventImages/" + fileName));
                        imgUploadEvent.ImageUrl = "~/EventImages/" + fileName;

                        DateTime date = DateTime.ParseExact(txtUploadEventDate.Text.Trim(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                        string insert_event = "insert into Event_Table values (@event_name,@event_date,@event_venue,@event_details,@event_image_path)";
                        SqlCommand cmd = new SqlCommand(insert_event, conn);
                        cmd.Parameters.AddWithValue("@event_name", txtUploadEventName.Text);
                        cmd.Parameters.AddWithValue("@event_date", txtUploadEventDate.Text);
                        cmd.Parameters.AddWithValue("@event_venue", txtUploadEventVenue.Text);
                        cmd.Parameters.AddWithValue("@event_details", txtUploadEventDetails.Text);
                        cmd.Parameters.AddWithValue("@event_image_path", "~/EventImages/" + fileName);

                        cmd.ExecuteNonQuery();
                        Response.Redirect("AdminEvents.aspx");
                    }
                }
            }
            catch (Exception ae)
            {
                txtUploadEventName.Text = ae.ToString();
            }
        }
    }
}