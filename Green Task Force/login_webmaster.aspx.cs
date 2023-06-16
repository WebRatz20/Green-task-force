using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Green_Task_Force
{
    public partial class login_webmaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtusername.Text=="webmaster")
            {
                if(txtpw.Text=="web123")
                {
                    Response.Redirect("webmaster.aspx");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Wrong password", "Invalid password('please enter a valid password');", true);
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Wrong user name", "Invalid Username('Please Enter a valid username');", true);

            }
        }
    }
}