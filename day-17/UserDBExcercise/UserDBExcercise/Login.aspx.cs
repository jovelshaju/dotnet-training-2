using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserDBExcercise
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string constr = "server=IND365;database=SecureDB;trusted_connection=true";
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnSignIn_click(object sender, EventArgs e)
        {
            try
            {
                
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "select * from UsersInfo where username=@usrname and userpswd = @usrpswd"
                };

                cmd.Parameters.AddWithValue("@usrname", txtUsrName.Text);
                cmd.Parameters.AddWithValue("@usrpswd", txtUsrPswd.Text);

                con.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    FormsAuthentication.RedirectFromLoginPage(txtUsrName.Text, true);

                }
                else
                {
                    lblMsg.Text = "Error: Invalid Credentials";
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