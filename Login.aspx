<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Gucera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Login </title>

    <style type="text/css">
        .auto-style2 {
            position: absolute;
            top: 72px;
            left: 112px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 112px;
            left: 114px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 171px;
            left: 77px;
            z-index: 1;
            width: 98px;
        }
        .auto-style5 {
            position: absolute;
            top: 206px;
            left: 76px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 142px;
            left: 70px;
            z-index: 1;
            width: 253px;
        }
    </style>
</head>
<body style="height: 234px">
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align:center">Login</h1>
        </div>
        Username&nbsp;
        <asp:TextBox ID="username" runat="server" CssClass="auto-style2"></asp:TextBox>
        <p>
            password<asp:TextBox ID="password" runat="server" CssClass="auto-style3"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style4" Text="login" OnClick="submit" />
        <p>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style6" Text="" ForeColor="Red"></asp:Label>
        </p>
        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style5" NavigateUrl="Register.aspx">Register</asp:HyperLink>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
