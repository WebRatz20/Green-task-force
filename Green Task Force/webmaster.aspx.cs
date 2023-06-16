using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Green_Task_Force
{
    public partial class webmaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("accountcreate.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("create_article.aspx");
        }
    }
}