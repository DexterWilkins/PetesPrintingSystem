<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDelete.aspx.cs" Inherits="StockDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblWarning" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Are you sure you wish to delete this item?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 14px; top: 61px; position: absolute; height: 26px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 71px; top: 62px; position: absolute; margin-bottom: 0px" Text="No" />
    </form>
</body>
</html>
