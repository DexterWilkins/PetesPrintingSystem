<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AOrder.aspx.cs" Inherits="AOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 18px;
            top: 211px;
            position: absolute;
        }
        .auto-style2 {
            position: absolute;
            top: 210px;
            left: 63px;
            z-index: 1;
            bottom: 363px;
        }
        .auto-style3 {
            position: absolute;
            top: 167px;
            left: 36px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnOk" runat="server" CssClass="auto-style1" Text="Ok" />
        </div>
        <p>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style3"></asp:Label>
        </p>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style2" Text="Cancel" />
    </form>
</body>
</html>
