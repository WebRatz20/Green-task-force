<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create_article.aspx.cs" Inherits="Green_Task_Force.create_article" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form8" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
                 <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                        <br />
                    <asp:TextBox ID="TextBox2" runat="server" Width="465px"></asp:TextBox>
             </asp:TableCell>
                </asp:TableRow>
                  <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
                        <br />
                    <asp:TextBox ID="TextBox3" runat="server" Width="465px"></asp:TextBox>
             </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                         <asp:Label ID="Label3" runat="server" Text="Article"></asp:Label>
                        <br/>
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="300" Width="600"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Post" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
