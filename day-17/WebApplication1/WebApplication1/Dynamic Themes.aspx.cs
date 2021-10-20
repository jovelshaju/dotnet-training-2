using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Dynamic_Themes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DirectoryInfo themeDir = new DirectoryInfo(Server.MapPath("App_Themes"));
                ddlThemes.DataTextField = "Name";
                ddlThemes.DataSource = themeDir.GetDirectories();
                ddlThemes.DataBind();
            }

        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["Theme"] == null)
            {
                // No theme has been chosen. Choose a default
                // (or set a blank string to make sure no theme
                // is used).
                Page.Theme = "";
            }
            else
            {
                Page.Theme = (string)Session["Theme"];
            }
        }
        protected void btnAplyTh_click(object sender, EventArgs e)
        {
            Session["Theme"] = ddlThemes.SelectedValue;

            // Refresh the page.
            Server.Transfer(Request.FilePath);
        }

        protected void btnClTh_click(object sender, EventArgs e)
        {
            Session["Theme"] = "";

            // Refresh the page.
            Server.Transfer(Request.FilePath);
        }
    }
}