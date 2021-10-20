using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ThreeMethod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Can redirect to pages outside server and inside
        protected void btnRR_click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.google.co.in/");
        }

        //Can only redirect to within server
        protected void btnST_click(object sender, EventArgs e)
        {
            Server.Transfer("Home.aspx");
        }
    }
}