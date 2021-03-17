<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDelete.aspx.cs" Inherits="CustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this Customer?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style1" OnClick="btnYes_Click" Text="Yes" Width="56px" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style2" OnClick="btnNo_Click" Text="No" Width="61px" />
    </form>
</body>
</html>
