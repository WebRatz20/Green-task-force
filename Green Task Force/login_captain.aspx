<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_captain.aspx.cs" Inherits="Green_Task_Force.login_captain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
             <div>
            <center>
                <asp:Label ID="Label1" runat="server" Text="Green Captian Login"></asp:Label></center>
            <br/>
            <Center>
                <asp:Label ID="Label2" runat="server" Text="UserName"></asp:Label>
                &nbsp;
                &nbsp;
                &nbsp;
                <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                <br/>

                                <br/>

                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                &nbsp;
                &nbsp;
                &nbsp;
                <asp:TextBox ID="txtpw" runat="server"></asp:TextBox>
                
                <br/>
                                <br/>
                <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" />

                </Center>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
