<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 19px;
            left: 11px;
            z-index: 1;
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" Text="Customer " />
            <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Font-Bold="True" Text="PetesPrintingSystem"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOrderPart" runat="server" OnClick="btnOrderPart_Click" Text="Order Part" />
        </p>
        <p>
            <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" Text="Stock " />
        </p>
    </form>
</body>
</html>
