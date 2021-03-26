<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDefult.aspx.cs" Inherits="OrderDefult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 34px;
            left: 25px;
            z-index: 1;
            width: 299px;
            height: 239px;
        }
        .auto-style2 {
            position: absolute;
            top: 283px;
            left: 31px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 337px;
            left: 25px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 368px;
            left: 27px;
            z-index: 1;
            width: 201px;
        }
        .auto-style5 {
            position: absolute;
            top: 437px;
            left: 25px;
            z-index: 1;
            width: 137px;
        }
        .auto-style6 {
            position: absolute;
            top: 437px;
            z-index: 1;
            width: 116px;
            left: 175px;
        }
        .auto-style7 {
            position: absolute;
            top: 501px;
            left: 25px;
            z-index: 1;
            width: 49px;
        }
        .auto-style8 {
            position: absolute;
            top: 501px;
            left: 83px;
            z-index: 1;
            width: 44px;
        }
        .auto-style9 {
            position: absolute;
            top: 501px;
            left: 141px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstDisplay" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style2"></asp:Label>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="Please Enter a part Number"></asp:Label>
        <asp:TextBox ID="txtEnterPartNo" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style5" OnClick="btnApply_Click" Text="Apply" />
        <asp:Button ID="btnDisplay" runat="server" CssClass="auto-style6" OnClick="btnDisplay_Click" Text="Display" />
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style7" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style8" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style9" OnClick="btnDelete_Click" Text="Delete" />
    </form>
</body>
</html>
