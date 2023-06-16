<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_user.aspx.cs" Inherits="Green_Task_Force.login_user" %>

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
            <div class="color"></div>
             <div class="box">
           <div class="container">
                    <div class="form">
        <div>
            <table class="style1">
                <tr>
                    <td >
                        <h2>Log In</h2><br /><br />
                    </td>
                </tr>
                
                 <tr>
                    <td   >
                        <b>Email:</b></td>
                        <td >
                        <asp:TextBox ID="TextBox31" runat="server"  CssClass="style"></asp:TextBox><br /><br /> </td>  
                </tr>
                  <tr >
                    <td  >
                        <b>Password:</b></td>
                     <td>
                     <asp:TextBox ID="TextBox32" runat="server" CssClass="style"></asp:TextBox><br /><br /> </td>
                    
                </tr>
                <tr>
                    <td>
                    <asp:Label ID="Label1" runat="server" Text="New user"></asp:Label>
                    <asp:Button ID="btnreg" runat="server" Text="Register Now" Onclick="btnext_Click"/>
                    &nbsp;</td></tr>
                 <tr>   
                    <td ></td>
                    <td>
                    <asp:Button ID="Button1" runat="server"  Text="LOG IN" CssClass="btnsubmit" OnClick="Button1_Click" /></td>
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
