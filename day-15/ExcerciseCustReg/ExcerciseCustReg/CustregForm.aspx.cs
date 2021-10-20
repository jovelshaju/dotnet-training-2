using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExcerciseCustReg
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DetailsLbl.Visible = false;
        }

        protected void NameLengthCheck(object source, ServerValidateEventArgs args)
        {

            string name = args.Value;
            if (name.Length >= 6)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                DetailsLbl.Visible = true;
                DetailsLbl.Text = "Registration Successful";
                DetailsLbl.Text += $"<br>Username: {usrNameInput.Text}";
                DetailsLbl.Text += $"<br>EMail-ID: {usrMailIDInput.Text}";
                DetailsLbl.Text += $"<br>Gender: {usrGenderInput.SelectedValue}";
                DetailsLbl.Text += $"<br>City: {usrCityInput.SelectedValue}";
                DetailsLbl.Text += $"<br>User's Favourite:";
                foreach (ListItem item in usrChoicesInput.Items)
                {
                    if (item.Selected)
                    {
                        DetailsLbl.Text += $"{item.Value}<br>";
                    }
                }
            }
        }
    }
}