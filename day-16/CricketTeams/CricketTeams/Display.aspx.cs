using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CricketTeams
{
    public partial class Display : System.Web.UI.Page
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter sda;
        static DataSet ds;
        static string constr = "server=IND365;database=CricDB;trusted_connection=true";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "select * from Teams"



                };
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                con.Open();
                sda.Fill(ds);
                lblMsg.Text = "Number of Teams:" + ds.Tables[0].Rows.Count;
                gvTeams.DataSource = ds.Tables[0];
                gvTeams.DataBind();
            }
            catch (SqlException se)
            {
                lblMsg.Text = "Server Error!" + se.Message;
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Application Error" + ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}