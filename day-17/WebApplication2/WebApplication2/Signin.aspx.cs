using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnSignIn_click(object sender, EventArgs e)
        {
            string username = "sam123";
            string password = "pass";

            if(txtUsrName.Text==username && txtUsrPswd.Text == password)
            {
                FormsAuthentication.RedirectFromLoginPage(txtUsrName.Text, true);
            }
            else
            {
                lblMsg.Text = "Error: Invalid Credentials";
            }
        }
    }
}