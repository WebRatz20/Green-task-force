using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Green_Task_Force
{
    public partial class markers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}

///tried to add markers to map and get the incident but didnt work

/*using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Web.UI;

public partial class markers : System.Web.UI.Page
{
    private const int ImageWidth = 640;
    private const int ImageHeight = 480;
     string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\greencaptain.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);

    public object YTextBox { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Load the image
            string imagePath = Server.MapPath("~/Images/MyImage.jpg");
            Image1.ImageUrl = "~/Images/MyImage.jpg";
            ViewState["ImagePath"] = imagePath;

            // Load the existing markers from the database
            LoadMarkers();
        }
    }

    protected void SaveButton_Click(object sender, EventArgs e)
    {
        // Get the position of the marker
        float x = float.Parse(XTextBox.Text);
        float y = float.Parse(YTextBox.Text);

        // Save the marker to the database
        using (var connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            var command = new MySqlCommand("INSERT INTO Markers (X, Y) VALUES (@X, @Y)", connection);
            command.Parameters.AddWithValue("@X", x);
            command.Parameters.AddWithValue("@Y", y);
            command.ExecuteNonQuery();
        }

        // Add the marker to the image
        AddMarkerToImage(x, y);

        // Refresh the page
        Response.Redirect(Request.RawUrl);
    }

    private void LoadMarkers()
    {
        using (var connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            var command = new MySqlCommand("SELECT X, Y FROM Markers", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                float x = reader.GetFloat(0);
                float y = reader.GetFloat(1);
                AddMarkerToImage(x, y);
            }
            reader.Close();
        }
    }

    private void AddMarkerToImage(float x, float y)
    {
        // Load the image
        string imagePath = (string)ViewState["ImagePath"];
        var image = new Bitmap(imagePath);

        // Compute the marker position in pixels
        int markerX = (int)(x * ImageWidth);
        int markerY = (int)(y * ImageHeight);

        // Draw the marker on the image
        using (var graphics = Graphics.FromImage(image))
        using (var pen = new Pen(Color.Red, 3))
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.DrawEllipse(pen, markerX - 5, markerY - 5, 10, 10);
        }

        // Save the image to a MemoryStream
        using (var memoryStream = new MemoryStream())
        {
            image.Save(memoryStream, ImageFormat.Jpeg);
            var imageData = memoryStream.ToArray();

            // Save the image to the ViewState
            ViewState["ImageBytes"] = imageData;

            // Display the image
            Image2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String(imageData);
        }
    }
}
}*/