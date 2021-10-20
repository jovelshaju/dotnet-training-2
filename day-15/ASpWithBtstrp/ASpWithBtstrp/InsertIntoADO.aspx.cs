using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASpWithBtstrp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        static SqlConnection con;
        static SqlCommand com;
        static string constr = "server=IND365;database=Day15DB;trusted_connection=true;";
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
        }

        protected void btn_Reg_Cust(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            try
            {
                con = new SqlConnection(constr);
                com = new SqlCommand()
                {
                    Connection = con,
                    CommandText = "insert into Customers values (@id,@name,@email,@contact)"
                };
                com.Parameters.AddWithValue("@id", int.Parse(usrIDInput.Text));
                com.Parameters.AddWithValue("@name", usrnameInput.Text);
                com.Parameters.AddWithValue("@email", usrEmailInput.Text);
                com.Parameters.AddWithValue("@contact", usrContactInput.Text);

                con.Open();
                com.ExecuteNonQuery();
                lblMsg.Text = "Record Inserted";

            }
            catch (SqlException se)
            {
                lblMsg.Text = "Server Error: " + se.Message;
            }
            catch(Exception ex)
            {
                lblMsg.Text = "Application Error: " + ex.Message;

            }
            finally
            {
                con.Close();
            }

        }
    }
}