using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASpWithBtstrp
{
    public partial class UploadFileEx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
        }
        protected void btnUpload_click(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            try
            {
                if (imgUpload.HasFile)
                {
                    string filename = imgUpload.PostedFile.FileName;
                    string ext = Path.GetExtension(filename);
                    if((ext==".jpg") || (ext == ".png") || (ext == ".gif") || (ext == ".jpeg"))
                    {
                        imgUpload.SaveAs(Server.MapPath("/UImages/" + filename));
                        lblMsg.Text = "Image Uploaded";
                    }
                    else
                    {
                        lblMsg.ForeColor = Color.Green;
                        lblMsg.Text = "File format not supported";

                    }
                }
                else
                {
                    lblMsg.Text = "Please Upload A File";

                }

            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;
            }

        }

    }
}