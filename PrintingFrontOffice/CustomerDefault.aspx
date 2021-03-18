<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDefault.aspx.cs" Inherits="CustomerDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 499px;
        }
        .auto-style2 {}
        .auto-style3 {}
        .auto-style4 {}
        .auto-style5 {}
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomers" runat="server" CssClass="auto-style2" Height="239px" Width="487px" OnSelectedIndexChanged="lstCustomers_SelectedIndexChanged" DataSourceID="SqlDataSource1" DataTextField="ForeName" DataValueField="LastName"></asp:ListBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerDatabaseConnectionString %>" SelectCommand="SELECT [CustomerNo], [Title], [ForeName], [LastName] FROM [tblCustomer]"></asp:SqlDataSource>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Please Enter a Last Name"></asp:Label>
        <p>
            <asp:TextBox ID="txtLastNameFilter" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style3" Text="Apply" Width="85px" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style4" OnClick="btnAdd_Click" Text="Add" Width="49px" />
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style5" Text="Edit" Width="51px" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
