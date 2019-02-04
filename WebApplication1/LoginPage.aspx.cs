using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if ((txtUserName.Text == "admin") && (txtPassword.Text == "admin"))
            {
                lblMsg.Text = " Valid User";
            }
            else
            {
                lblMsg.Text = "Invalid User";
            }
        }

    }
}