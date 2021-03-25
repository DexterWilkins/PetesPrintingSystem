<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stock.aspx.cs" Inherits="Stock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 400px">
    <form id="form1" runat="server">
        <div style="height: 395px">
            <asp:Label ID="lblStockNo" runat="server" style="z-index: 1; left: 49px; top: 57px; position: absolute" Text="Stock No"></asp:Label>
            <asp:Label ID="lblStockDescription" runat="server" style="z-index: 1; left: 48px; top: 92px; position: absolute" Text="Stock Description"></asp:Label>
            <asp:Label ID="lblStockLocation" runat="server" style="z-index: 1; left: 48px; top: 132px; position: absolute" Text="Stock Location"></asp:Label>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 49px; top: 171px; position: absolute" Text="Date Added"></asp:Label>
            <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 44px; top: 213px; position: absolute" Text="In Stock" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 48px; top: 257px; position: absolute"></asp:Label>
            <asp:Button ID="btnOkay" runat="server" OnClick="btnOkay_Click" style="z-index: 1; left: 50px; top: 313px; position: absolute" Text="Okay" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 116px; top: 313px; position: absolute" Text="Cancel" />
            <asp:TextBox ID="txtStockNo" runat="server" style="z-index: 1; left: 190px; top: 55px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtLocation" runat="server" style="z-index: 1; left: 189px; top: 130px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 188px; top: 171px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 190px; top: 92px; position: absolute"></asp:TextBox>
        </div>    
    </form>
</body>
</html>
