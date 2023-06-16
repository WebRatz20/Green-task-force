<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Green_Task_Force.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="styles/Style.css" />
    <title></title>
     <style type="text/css">
         .auto-style1 {
             width: 528px;
         }
     </style>
</head>
<body style="height: 64px; width: 619px">
    <form id="form1" runat="server">
        <div>
            Greeen Task Force<br />
        </div>
        <p>
            Chose your Role</p>
        <asp:Panel ID="Panel1" runat="server" Height="86px" Width="446px">
            <asp:Button ID="Button1" runat="server" Text="Green Captain" Height="65px" OnClick="Button1_Click" Width="96px" />
            <asp:Button ID="Button2" runat="server" Height="62px" OnClick="Button2_Click" Text="Gtf Member" Width="102px" />
            <asp:Button ID="Button4" runat="server" Height="63px" Text="Web Master" Width="103px" OnClick="Button3_Click" />
            <asp:Button ID="Button5" runat="server" Height="61px" OnClick="Button5_Click" style="margin-right: 36px" Text="Articles" Width="103px" />
        </asp:Panel>
        <p>
        </p>
        <table>
            <tr>
       <th>
            <asp:Button ID="incident3" runat="server" Text="Incident 3" style="position:absolute; top:418px; left:211px; border-radius: 10px;" />
            <asp:Button ID="incident4" runat="server" Text="incident 4" style="position:absolute; top:558px; left:287px; border-radius: 10px;" />
<asp:Button ID="incident2" runat="server" Text="incident 2" style="position:absolute; top:501px; left:449px; height: 23px; border-radius: 10px;" />
            <asp:Image ID="MyImage" runat="server" ImageUrl="~/img/clmb.png" Height="519px" Width="597px" />
<!--incident 2 button-->
<!--incident 3 button-->
    <!--incident 4 button-->
            <!--incident 1 button-->
<asp:Button ID="incident1" runat="server" Text="Incident 1" style="position:absolute; top:334px; left:357px; border-radius: 10px; height: 26px;" />
           </th>
                <th class="auto-style1" >
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    </th>
           </tr>
            </table>
    </form>
</body>
</html>
