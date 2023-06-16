using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Green_Task_Force
{
    public partial class login_staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            // Get the username and password from the textboxes
            string username = txtusername.Text.Trim();
            string password = txtpw.Text.Trim();

            // Connect to the SQL Server database
            // conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\greencaptain.mdf;Integrated Security=True;Connect Timeout=30";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\greencaptain.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);

            // Create a SQL command to retrieve the user's password
            string query = "SELECT password FROM Staff WHERE name = @Username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);

            try
            {
                // Open the database connection
                connection.Open();

                // Execute the SQL command and get the user's password
                string dbPassword = (string)command.ExecuteScalar();

                // Compare the user's password with the password entered by the user
                if (password == dbPassword)
                {
                    // If the passwords match, redirect the user to the home page
                    Response.Write("Working");
                  //  Response.Redirect("staff.aspx");
                }
                else
                {
                    // If the passwords don't match, display an error message
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Wrong user name", "Invalid Password('Please Enter a valid password');", true);

                }
            }
            catch (Exception ex)
            {
                // Display an error message if there was a problem connecting to the database
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Wrong user name", "Invalid Username('Please Enter a valid username');", true);

            }
            finally
            {
                // Close the database connection
                connection.Close();
            }
        }
    }
}