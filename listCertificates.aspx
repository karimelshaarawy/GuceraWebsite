<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listCertificates.aspx.cs" Inherits="Gucera.listCertificates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 34px;
            left: 125px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 34px;
            left: 10px;
            z-index: 1;
            width: 81px;
        }
        .auto-style3 {
            position: absolute;
            top: 88px;
            left: 15px;
            z-index: 1;
            width: 140px;
        }
        .auto-style4 {
            position: absolute;
            top: 59px;
            left: 55px;
            z-index: 1;
            width: 391px;
        }
        .auto-style5 {
            width: 258px;
            height: 59px;
            position: absolute;
            top: 136px;
            left: 46px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="courseId" runat="server" CssClass="auto-style1"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="Course ID"></asp:Label>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style3" ForeColor="#000099" Text="List Certificates " OnClick="Button1_Click" />
        <asp:Label ID="Label2" runat="server" CssClass="auto-style4" Text="" ForeColor="Red"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style5">
        </asp:GridView>
    </form>
</body>
</html>
