﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssuePromoCode.aspx.cs" Inherits="Gucera.IssuePromoCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <h1>Issue PromoCode</h1>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Student ID"></asp:Label>
            <asp:TextBox ID="Txt1" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label2" runat="server" Text="PromoCode"></asp:Label>
        <asp:TextBox ID="Txt2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Issue" runat="server" OnClick="Issue_Click" Text="Issue" />
        </p>
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
