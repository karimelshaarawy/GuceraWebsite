<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Promocode.aspx.cs" Inherits="Gucera.Promocode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>promocodes</title>
    <style type="text/css">
        .auto-style1 {
            width: 522px;
            height: 299px;
            position: absolute;
            top: 89px;
            left: 136px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <h1 style="text-align:center;">Promocodes</h1>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style1" BackColor="Black" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" EmptyDataText="No promocodes found" ForeColor="White" Height="50">
        </asp:GridView>
    </form>
</body>
</html>
