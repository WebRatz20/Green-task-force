using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Green_Task_Force
{
    public partial class index : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\greencaptain.mdf;Integrated Security=True;Connect Timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Articles";
            // Create a SqlCommand object with the SQL query and the SqlConnection object
            SqlCommand command = new SqlCommand(query, con);

            // Create a SqlDataAdapter object with the SqlCommand object
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Create a DataTable object to hold the data retrieved from the database
            DataTable dataTable = new DataTable();

            // Use the SqlDataAdapter object to fill the DataTable object with the data from the database
            adapter.Fill(dataTable);

            // Set the DataSource property of the GridView control to the DataTable object
            GridView1.Visible = true;
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login_captain.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("login_webmaster.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("view_article.aspx");
        }

        protected void incident2_Click(object sender, EventArgs e)
        {

        }
    }
}