using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Green_Task_Force
{
    public partial class create_article : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Acer\\Documents\\greencaptain.mdf;Integrated Security=True;Connect Timeout=30";
          
           

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Articles values (@username,@title,@article)", conn);
                cmd.Parameters.AddWithValue("@username", TextBox2.Text);
                cmd.Parameters.AddWithValue("@title", TextBox3.Text);
                cmd.Parameters.AddWithValue("@article", TextBox1.Text);
                cmd.ExecuteNonQuery();
                Response.Write("dne");
               Response.Redirect("webmaster.aspx");
            }
            catch(Exception ex)
            {
                Response.Write(ex);
            }

            finally
            {
                conn.Close();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";

            }
            
        }
    }
}