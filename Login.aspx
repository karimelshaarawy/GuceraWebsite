<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Gucera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Login </title>
    <style type="text/css">
        .auto-style2 {
            position: absolute;
            top: 37px;
            left: 120px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 78px;
            left: 120px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 126px;
            left: 78px;
            z-index: 1;
            width: 98px;
        }
        .auto-style5 {
            position: absolute;
            top: 172px;
            left: 28px;
            z-index: 1;
        }
    </style>
</head>
<body style="height: 234px">
    <form id="form1" runat="server">
        <div>
            Login<br />
        </div>
        Username&nbsp;
        <asp:TextBox ID="username" runat="server" CssClass="auto-style2"></asp:TextBox>
        <p>
            password<asp:TextBox ID="password" runat="server" CssClass="auto-style3"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style4" Text="login" OnClick="submit" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style5" NavigateUrl="Register.aspx">Register</asp:HyperLink>
    </form>
</body>
</html>
