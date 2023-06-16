<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="incident_report.aspx.cs" Inherits="Green_Task_Force.incident_report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            


            <div class="color"></div>
            <div class="color"></div>
             <div class="box">
                <div class="container">
                    <div class="form">
        <div>

            </div>
            <table class="style1">
                <tr>
                    <td><h2>Account Information</h2><br /><br /></td>
                    </tr>


                <tr>
                    <td> <asp:Label ID="Label1" runat="server" Text="User_Name :"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox10" runat="server"  CssClass="style"></asp:TextBox><br /><br /></td>
                    </tr>
            
                <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Incident_ID :"></asp:Label></td>
            <td> <asp:TextBox ID="TextBox11" runat="server"  CssClass="style"></asp:TextBox><br /><br /></td>
                    </tr>
                <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Location :"></asp:Label></td>
            <td><asp:TextBox ID="TextBox12" runat="server"  CssClass="style"></asp:TextBox><br /><br /></td>
                    </tr>

                <tr>
          <td>  <asp:Label ID="Label4" runat="server" Text="Date :"></asp:Label></td>
           <td><asp:TextBox ID="TextBox14" runat="server"  CssClass="style"></asp:TextBox><br /><br /></td>
               
                    </tr>

                <tr>
            <td><asp:Label ID="Label5" runat="server" Text="Description :"></asp:Label></td>
            <td><asp:TextBox ID="TextBox13" runat="server"  CssClass="styleDes"></asp:TextBox><br /><br /></td>
                    </tr>


            <td><asp:Label ID="Label6" runat="server" Text="Choose a Image :"></asp:Label></td>
             <td> 
               
                 <asp:FileUpload ID="FileUpload1" accept="image/*" runat="server" />
                   <label for="file">Choose a Photo</label>
                 <br /><br />

             </td>

                <tr>
                   <td> <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="bttonsubmit" OnClick="Button1_Click" /></td>
                    </tr>

                </table>

                        </div>
                    </div>
                 </div>
            </section>
        <div>
        </div>
    </form>
</body>
</html>
