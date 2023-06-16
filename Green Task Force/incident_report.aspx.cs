using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Green_Task_Force
{
    public partial class incident_report : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\greencaptain.mdf;Integrated Security=True;Connect Timeout=30");

        int Incident_ID;
        string User_Name, Location, Description, Date;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User_Name = TextBox10.Text;
            Incident_ID = int.Parse((TextBox11.Text));
            Location = TextBox12.Text;
            Description = TextBox13.Text;
            Date = TextBox14.Text;


            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N64AV14\SQLEXPRESS;Initial Catalog=PasinduAL;Integrated Security=True");
            string qry = "INSERT INTO complains VALUES ('" + Incident_ID + "','" + User_Name + "','" + Location + "','" + Date + "','" + Description + "')";

            SqlCommand cmd = new SqlCommand(qry, con);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("Incident Added successsfully");
            }

            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
            }

            TextBox10.Text = "";
            TextBox11.Text = "";

            TextBox12.Text = "";
            TextBox14.Text = "";
            TextBox13.Text = "";
        }
    }
}