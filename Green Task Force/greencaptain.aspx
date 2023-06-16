<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="greencaptain.aspx.cs" Inherits="Green_Task_Force.greencaptain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form2" runat="server">
        
            <asp:Label ID="Label1" runat="server" Text="Green Captain"></asp:Label>
        <div>
<asp:Button ID="incident3" runat="server" Text="Incident 3" style="position:absolute; top:322px; left:227px; border-radius: 10px;" OnClick="incident3_Click" />
            <asp:Button ID="incident4" runat="server" Text="incident 4" style="position:absolute; top:368px; left:371px; border-radius: 10px;" OnClick="incident4_Click" />
            <asp:Image ID="MyImage" runat="server" ImageUrl="~/img/clmb.png" Height="519px" Width="597px" />
<!--incident 2 button-->
<asp:Button ID="incident2" runat="server" Text="incident 2" style="position:absolute; top:195px; left:366px; height: 23px; border-radius: 10px;" OnClick="incident2_Click" />
<!--incident 3 button-->
    <!--incident 4 button-->
            <!--incident 1 button-->
<asp:Button ID="incident1" runat="server" Text="Incident 1" style="position:absolute; top:279px; left:489px; border-radius: 10px; height: 26px;" OnClick="incident1_Click" />

            <asp:GridView ID="complainview" runat="server" Height="262px" OnSelectedIndexChanged="complainview_SelectedIndexChanged" Width="340px" style="margin-top: 0px" >
         
                </asp:GridView>

            <asp:Panel ID="Panel1" runat="server" Height="60px" Visible="False" Width="512px">
                <asp:Button ID="btnimportant" runat="server" Text="Mark as Important" Height="43px" OnClick="btnimportant_Click" Width="114px" />
                <asp:Button ID="ok" runat="server" Height="44px" Text="OK" Width="95px" OnClick="ok_Click" />
                <asp:Button ID="removeincident" runat="server" Height="45px" OnClick="removeincident_Click" Text="Remove the Incident" Width="133px" />
            </asp:Panel>

            </div>
    </form>
</body>
</html>
