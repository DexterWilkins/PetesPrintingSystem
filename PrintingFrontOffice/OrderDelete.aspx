﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDelete.aspx.cs" Inherits="OrderDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 78px;
            left: 21px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 78px;
            left: 69px;
            z-index: 1;
            width: 37px;
        }
        .auto-style3 {
            position: absolute;
            top: 46px;
            left: 17px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style1" OnClick="btnYes_Click" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style2" OnClick="btnNo_Click" Text="No" />
        <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="Are you sure you want to delete this order?"></asp:Label>
    </form>
</body>
</html>
