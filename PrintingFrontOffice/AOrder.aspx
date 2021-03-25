<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AOrder.aspx.cs" Inherits="AOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 210px;
            left: 15px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 41px;
            left: 261px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 209px;
            left: 63px;
            z-index: 1;
            bottom: 364px;
        }
        .auto-style4 {
            position: absolute;
            top: 41px;
            left: 23px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 41px;
            left: 115px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 77px;
            left: 114px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 115px;
            left: 114px;
            z-index: 1;
            bottom: 462px;
        }
        .auto-style9 {
            position: absolute;
            top: 80px;
            left: 24px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 117px;
            left: 26px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 181px;
            left: 40px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 154px;
            left: 23px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 155px;
            left: 114px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="btnOk" runat="server" CssClass="auto-style1" Text="OK" />
            <asp:TextBox ID="txtOrderNo" runat="server" CssClass="auto-style5"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" CssClass="auto-style2" OnClick="btnFind_Click1" Text="Find" />
        </p>
        <p>
            <asp:TextBox ID="txtOrderDate" runat="server" CssClass="auto-style6"></asp:TextBox>
            <asp:Label ID="lblOrderDate" runat="server" CssClass="auto-style9" Text="OrderDate"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblDeliveryDate" runat="server" CssClass="auto-style10" Text="DeliveryDate"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblOrderNo" runat="server" CssClass="auto-style4" Text="OrderNo"></asp:Label>
            <asp:TextBox ID="txtDeliveryDate" runat="server" CssClass="auto-style7"></asp:TextBox>
            
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style11"></asp:Label>
            <asp:TextBox ID="txtPartNo" runat="server" CssClass="auto-style13"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style3" Text="Cancel" />
        <asp:Label ID="lblPartNo" runat="server" CssClass="auto-style12" Text="PartNo"></asp:Label>
    </form>
</body>
</html>
