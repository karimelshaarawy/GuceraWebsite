<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Gucera.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 297px;
        }
        .auto-style2 {
            position: absolute;
            top: 15px;
            left: 89px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 53px;
            left: 90px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 91px;
            left: 88px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 130px;
            left: 89px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 167px;
            left: 75px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 206px;
            left: 84px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 258px;
            left: 48px;
            z-index: 1;
            width: 155px;
            right: 626px;
        }
        .auto-style9 {
            position: absolute;
            top: 259px;
            left: 236px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 167px;
            left: 146px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
            First name
            <asp:TextBox ID="firstName" runat="server" CssClass="auto-style2"></asp:TextBox>
        </div>
        <p>
            Last name<asp:TextBox ID="lastName" runat="server" CssClass="auto-style3"></asp:TextBox>
        </p>
        Password<asp:TextBox ID="password" runat="server" CssClass="auto-style4"></asp:TextBox>
        <br />
        <br />
        Email<asp:TextBox ID="email" runat="server" CssClass="auto-style5"></asp:TextBox>
        <br />
        <br />
        Gender<asp:CheckBox ID="male" runat="server" CssClass="auto-style6" Text="Male" TextAlign="Left" OnCheckedChanged="male_CheckedChanged" />
        <asp:CheckBox ID="female" runat="server" CssClass="auto-style11" OnCheckedChanged="female_CheckedChanged" Text="Female" TextAlign="Left" />
        <br />
        <br />
        Address<asp:TextBox ID="Address" runat="server" CssClass="auto-style7"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style8" OnClick="studentRegister" Text="Register as a student" />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style9" Text="Register as an Instructor" OnClick="InstructorRegister" />
    </form>
</body>
</html>
