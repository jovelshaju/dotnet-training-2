using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASpWithBtstrp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter sda;
        static DataSet ds;
        static string constr = "server=IND365;database=Day15DB;trusted_connection=true";




        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "select * from Customers"



                };
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                con.Open();
                sda.Fill(ds);
                lblMsg.Text = "Number of Customers:" + ds.Tables[0].Rows.Count;
                gvCustomers.DataSource = ds.Tables[0];
                gvCustomers.DataBind();
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