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
    public partial class greencaptain : System.Web.UI.Page


    {

        static int selectedid;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\greencaptain.mdf;Integrated Security=True;Connect Timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void complainview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnimportant_Click(object sender, EventArgs e)
        {
            string clickedButtonID = Session["ClickedButtonID"] as string;

            if (clickedButtonID != null)
            {
                Button clickedButton = FindControl(clickedButtonID) as Button;

                if (clickedButton != null)
                {
                    //clickedButton.BackColor = System.Drawing.Color.Red;
                    if (clickedButton.BackColor == System.Drawing.Color.Red)
                    {
                        clickedButton.BackColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        clickedButton.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        protected void incident2_Click(object sender, EventArgs e)
        {
            Session["ClickedButtonID"] = incident2.ID;
            selectedid = 2;

            con.Open();
            string query = "SELECT * FROM complains WHERE incidentid='" + selectedid + "'";

            // Define the connection string for your database
            //string connectionString = "Your connection string here";

            // Create a SqlConnection object with the connection string
            // SqlConnection connection = new SqlConnection(connectionString);

            // Create a SqlCommand object with the SQL query and the SqlConnection object
            SqlCommand command = new SqlCommand(query, con);

            // Create a SqlDataAdapter object with the SqlCommand object
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Create a DataTable object to hold the data retrieved from the database
            DataTable dataTable = new DataTable();

            // Use the SqlDataAdapter object to fill the DataTable object with the data from the database
            adapter.Fill(dataTable);

            // Set the DataSource property of the GridView control to the DataTable object
            complainview.Visible = true;
            complainview.DataSource = dataTable;

            // Bind the data to the GridView control
            complainview.DataBind();
            Panel1.Visible = true;
        }

        protected void incident1_Click(object sender, EventArgs e)
        {
            Session["ClickedButtonID"] = incident1.ID;
            selectedid = 1;

            con.Open();
            string query = "SELECT * FROM complains WHERE incidentid='" + selectedid + "'";

            // Define the connection string for your database
            //string connectionString = "Your connection string here";

            // Create a SqlConnection object with the connection string
            // SqlConnection connection = new SqlConnection(connectionString);

            // Create a SqlCommand object with the SQL query and the SqlConnection object
            SqlCommand command = new SqlCommand(query, con);

            // Create a SqlDataAdapter object with the SqlCommand object
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Create a DataTable object to hold the data retrieved from the database
            DataTable dataTable = new DataTable();

            // Use the SqlDataAdapter object to fill the DataTable object with the data from the database
            adapter.Fill(dataTable);

            // Set the DataSource property of the GridView control to the DataTable object
            complainview.Visible = true;
            complainview.DataSource = dataTable;

            // Bind the data to the GridView control
            complainview.DataBind();
            Panel1.Visible = true;
        }

        protected void incident3_Click(object sender, EventArgs e)
        {
            Session["ClickedButtonID"] = incident3.ID;
            selectedid = 3;

            con.Open();
            string query = "SELECT * FROM complains WHERE incidentid='" + selectedid + "'";

            // Define the connection string for your database
            //string connectionString = "Your connection string here";

            // Create a SqlConnection object with the connection string
            // SqlConnection connection = new SqlConnection(connectionString);

            // Create a SqlCommand object with the SQL query and the SqlConnection object
            SqlCommand command = new SqlCommand(query, con);

            // Create a SqlDataAdapter object with the SqlCommand object
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Create a DataTable object to hold the data retrieved from the database
            DataTable dataTable = new DataTable();

            // Use the SqlDataAdapter object to fill the DataTable object with the data from the database
            adapter.Fill(dataTable);

            // Set the DataSource property of the GridView control to the DataTable object
            complainview.Visible = true;
            complainview.DataSource = dataTable;

            // Bind the data to the GridView control
            complainview.DataBind();
            Panel1.Visible = true;
        }

        protected void incident4_Click(object sender, EventArgs e)
        {
            Session["ClickedButtonID"] = incident4.ID;
            selectedid = 4;

            con.Open();
            string query = "SELECT * FROM complains WHERE incidentid='" + selectedid + "'";

            // Define the connection string for your database
            //string connectionString = "Your connection string here";

            // Create a SqlConnection object with the connection string
            // SqlConnection connection = new SqlConnection(connectionString);

            // Create a SqlCommand object with the SQL query and the SqlConnection object
            SqlCommand command = new SqlCommand(query, con);

            // Create a SqlDataAdapter object with the SqlCommand object
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Create a DataTable object to hold the data retrieved from the database
            DataTable dataTable = new DataTable();

            // Use the SqlDataAdapter object to fill the DataTable object with the data from the database
            adapter.Fill(dataTable);

            // Set the DataSource property of the GridView control to the DataTable object
            complainview.Visible = true;
            complainview.DataSource = dataTable;

            // Bind the data to the GridView control
            complainview.DataBind();
            Panel1.Visible = true;
        }

        protected void ok_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            complainview.Visible = false;
        }

        protected void removeincident_Click(object sender, EventArgs e)
        {
            //tst
            string qry = "INSERT INTO employee VALUES (101,'')";
            //string qry = "INSERT INTO employee VALUES ('100','navindu','20000','2000/03/15','male','single','sdfsddf','32131')";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("Employee Added successsfully");
            }

            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
            }
            //tst end

            /*string del = "DELETE FROM complains WHERE incidentid='" + selectedid + "'";
            SqlCommand cmddel = new SqlCommand(del, con);
            try
            {
                con.Open();
                cmddel.ExecuteNonQuery();
                Response.Write(selectedid);
                
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            finally
            {
                con.Close();
            }*/
            Panel1.Visible = false;
            complainview.Visible = false;
        }
    }
}