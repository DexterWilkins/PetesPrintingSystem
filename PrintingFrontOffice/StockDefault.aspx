<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDefault.aspx.cs" Inherits="StockDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStock" runat="server" style="z-index: 1; left: 20px; top: 40px; position: absolute; height: 189px; width: 278px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 27px; top: 237px; position: absolute"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 24px; top: 275px; position: absolute; height: 27px; right: 764px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="Edit" runat="server" style="z-index: 1; left: 87px; top: 276px; position: absolute; height: 26px;" Text="Edit" OnClick="Edit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 155px; top: 275px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
