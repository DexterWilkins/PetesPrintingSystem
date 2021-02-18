<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 469px;
        }
        #form1 {
            height: 485px;
        }
        .auto-style2 {}
        .auto-style3 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Customer No&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerNo" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            Title&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            <br />
            ForeName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtForeName" runat="server"></asp:TextBox>
            <br />
            LastName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            Customer Email&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
            <br />
            Date Added&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
            <br />
            Phone No&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="checkboxActive" runat="server" Text="Active" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" CssClass="auto-style2" OnClick="btnOK_Click" Text="OK" Width="54px" />
            <asp:Button ID="btnCancel" runat="server" CssClass="auto-style3" Text="Cancel" Width="67px" />
        </div>
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
