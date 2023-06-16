<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Green_Task_Force.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
         <section>
            <div class="color"></div>
            <div class="color"></div>
            <div class="color"></div>
            <div class="box">
                <div class="container">
                    <div class="form">
        <div>
            <table class="style1">
                <tr>
                    <td >
                        <h2>Registration Page</h2>
                    </td>
                </tr>
                 <tr>
                    <td >
                        <b>First Name:</b> </td>
                       <td>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="style"></asp:TextBox><br /><br /></td>
                </tr>
                 <tr>
                    <td >
                        <b>Last Name:</b></td>
                        <td>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="style"></asp:TextBox><br /><br /></td>   
                </tr>

                 <tr>
                    <td >
                        <b>Email:</b></td>
                        <td>
                        <asp:TextBox ID="TextBox3" runat="server"  CssClass="style"></asp:TextBox><br /><br /> </td>  
                </tr>
                 <tr>
                    <td >
                        <b>Gender:</b></td>
                     <td>
                         <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" /><br />
                         <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
                     <br /><br />
                     </td>
                </tr>
                 <tr>
                    <td >
                        <b>Address:</b></td>
                     <td>
                     <asp:TextBox ID="TextBox5" runat="server" CssClass="style"></asp:TextBox><br /><br /> </td>
                </tr>
                 <tr>
                    <td >
                        <b>Phone_No:</b></td>
                      <td>

                      <asp:TextBox ID="TextBox6" runat="server" CssClass="style"></asp:TextBox><br /><br /></td>
                     
                </tr>
                 <tr>
                    <td >
                        <b>Password:</b></td>
                     <td>
                     <asp:TextBox ID="TextBox7" runat="server" CssClass="style"></asp:TextBox><br /><br /> </td>
                    
                </tr>
                <tr>
                    <td >
                        <b>Confirm Password:</b></td>
                    <td> 
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="style"></asp:TextBox> <br /><br /></td>
                </tr>
                <tr>   
                    <td ></td>
                    <td>
                    <asp:Button ID="Button1" runat="server"  Text="Register" CssClass="btnsubmit" OnClick="Button1_Click" /></td>
                </tr>           
                </table>
        </div>
                        </div>
                      </div>
                    </div>
            </section>
    </form>
</body>
</html>
