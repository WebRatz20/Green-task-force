using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Green_Task_Force
{
    public partial class login_user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnext_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox31.Text.Trim();
            string password = TextBox32.Text.Trim();

            // Connect to the SQL Server database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\greencaptain.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);

            // Create a SQL command to retrieve the user's password
            string query = "SELECT pw FROM Register WHERE fname = @username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);

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
                  //  Response.Write("done");
                    Response.Redirect("incident_report.aspx");
                }
                else
                {
                    // If the passwords don't match, display an error message
                    Response.Write("done");
                    Response.Redirect("incident_report.aspx");
                }
            }
            catch (Exception ex)
            {
                // Display an error message if there was a problem connecting to the database
                Response.Write(ex);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }

        }
    }
}