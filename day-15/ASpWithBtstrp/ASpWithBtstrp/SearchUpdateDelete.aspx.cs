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
    public partial class SearchUpdateDelete : System.Web.UI.Page
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string constr = "server=IND365;database=Day15DB;trusted_connection=true";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataPanel.Visible = false;
            }
        }

        protected void btnSearch_click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = $"select * from Customers where CID={id}"
                };

                con.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DataPanel.Visible = true;
                    while (reader.Read())
                    {
                        usrCID.Text = reader["CId"].ToString();
                        usrName.Text = reader["CName"].ToString();
                        usrEMail.Text = reader["CEmail"].ToString();
                        usrContact.Text = reader["CContact"].ToString();
                    }
                }
                else
                {
                    msgLbl.Text = "Record Not Found";
                }
                
            }
            catch (SqlException se)
            {
                msgLbl.Text = "Server Error!" + se.Message;
            }
            catch (Exception ex)
            {
                msgLbl.Text = "Application Error" + ex.Message;
            }
            con.Close();
        }


        protected void btnUpdate_click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "update Customers set CId=@id,CName=@name,CEmail=@mail,CContact=@contact where CID=@id"
                };

                cmd.Parameters.AddWithValue("@id", int.Parse(usrCID.Text));
                cmd.Parameters.AddWithValue("@name", usrName.Text);
                cmd.Parameters.AddWithValue("@mail", usrEMail.Text);
                cmd.Parameters.AddWithValue("@contact", usrContact.Text);
                
                con.Open();
                cmd.ExecuteNonQuery();
                msgLbl.Text = "Record Updated";
                

            }
            catch (SqlException se)
            {
                msgLbl.Text = "Server Error!" + se.Message;
            }
            catch (Exception ex)
            {
                msgLbl.Text = "Application Error" + ex.Message;
            }
            con.Close();

        }

        protected void btnDelete_click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = $"delete from Customers where CID={id}"
                };

                con.Open();

                cmd.ExecuteNonQuery();
                msgLbl.Text = "Record Deleted";
                DataPanel.Visible = false;                

            }
            catch (SqlException se)
            {
                msgLbl.Text = "Server Error!" + se.Message;
            }
            catch (Exception ex)
            {
                msgLbl.Text = "Application Error" + ex.Message;
            }
            con.Close();

        }
    }
}