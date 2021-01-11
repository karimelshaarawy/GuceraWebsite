<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMobileNumber.aspx.cs" Inherits="Gucera.AddMobileNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 51px;
            left: 102px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 91px;
            left: 82px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="number" runat="server" CssClass="auto-style1"></asp:TextBox>
        <p>
            Number</p>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Text="Add Mobile Number" OnClick="Button1_Click" />
    </form>
</body>
</html>
