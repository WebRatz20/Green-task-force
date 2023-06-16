using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Green_Task_Force
{
    public partial class captain_sign : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\greencaptain.mdf;Integrated Security=True;Connect Timeout=30";
           

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Captain values (@name, @nic, @email, @password)", conn);
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@nic", TextBox2.Text);
                cmd.Parameters.AddWithValue("@email", TextBox3.Text);
                cmd.Parameters.AddWithValue("@password", TextBox4.Text);
                cmd.ExecuteNonQuery();
                Response.Write("done");
                //Response.Redirect("webmaster.aspx");
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
                TextBox4.Text = "";
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}