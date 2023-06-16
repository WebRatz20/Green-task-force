<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="accountcreate.aspx.cs" Inherits="Green_Task_Force.accountcreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create as a captain" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Create as a staff" />
        </div>
    </form>
</body>
</html>
