using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Green_Task_Force
{
    public partial class register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\greencaptain.mdf;Integrated Security=True;Connect Timeout=30");
        int Phone_No, Password, Confirm_Password;
        string First_Name, Last_Name, Email, Gender, Address;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            First_Name = TextBox1.Text;
            Last_Name = TextBox2.Text;
            Email = TextBox3.Text;

            if (RadioButton1.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            Address = TextBox5.Text;
            Phone_No = int.Parse(TextBox6.Text);
            Password = int.Parse(TextBox7.Text);
            Confirm_Password = int.Parse(TextBox8.Text);

            string qry = "INSERT INTO Register VALUES ('" + First_Name + "','" + Last_Name + "','" + Email + "','" + Gender + "','" + Address + "','" + Phone_No + "','" + Password + "','" + Confirm_Password + "')";

            SqlCommand cmd = new SqlCommand(qry, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("account created Succesfully");
                Response.Redirect("login_user.aspx");
            }

            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();

                TextBox1.Text = "";

                TextBox2.Text = "";
                TextBox3.Text = "";
                RadioButton1.Checked = false;
                RadioButton2.Checked = false;

                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";

            }
        }
    }
}