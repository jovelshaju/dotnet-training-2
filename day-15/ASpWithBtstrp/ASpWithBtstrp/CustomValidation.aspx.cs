using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASpWithBtstrp
{
    public partial class CustomValidation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResultLabel.Visible = false;
        }

        protected void CheckEven(object source, ServerValidateEventArgs args)
        {
            int num = int.Parse(args.Value);
            if (num % 2 == 0)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                ResultLabel.Visible = true;
                ResultLabel.Text = "Success";
            }
        }
    }
}