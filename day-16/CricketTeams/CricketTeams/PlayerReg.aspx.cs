using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CricketTeams
{
    public partial class PlayerReg : System.Web.UI.Page
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static string constr = "server=IND365;database=CricDB;trusted_connection=true";
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;

        }

        protected void btnRegister_click(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            try
            {
                string photoPath = "";
                con = new SqlConnection(constr);
                cmd = new SqlCommand()
                {
                    Connection = con,
                    CommandText = "insert into Player values (@id,@name,@tid,@dob,@photo)"
                };

                if (imgUpload.HasFile)
                {
                    string filename = imgUpload.PostedFile.FileName;
                    string ext = Path.GetExtension(filename);
                    photoPath = "/UploadedImages/Players/" + filename;
                    if ((ext == ".jpg") || (ext == ".png") || (ext == ".gif") || (ext == ".jpeg"))
                    {
                        imgUpload.SaveAs(Server.MapPath(photoPath));
                        cmd.Parameters.AddWithValue("@id", int.Parse(txtPlayerID.Text));
                        cmd.Parameters.AddWithValue("@name", txtPlayerName.Text);
                        cmd.Parameters.AddWithValue("@tid", TeamList.SelectedValue);
                        cmd.Parameters.AddWithValue("@dob", DateTime.Parse(calDOB.SelectedDate.ToString()));
                        cmd.Parameters.AddWithValue("@photo", photoPath);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        lblMsg.ForeColor = Color.Green;
                        lblMsg.Text = "Record Inserted";
                    }
                    else
                    {
                        lblMsg.Text = "File format not supported";

                    }
                }
                else
                {
                    lblMsg.Text = "Please Upload A File";

                }



            }
            catch (SqlException se)
            {
                lblMsg.Text = "Server Error: " + se.Message;
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Application Error: " + ex.Message;
            }
            con.Close();
        }
    }
}