<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCourse.aspx.cs" Inherits="Gucera.AddCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .label {
            display: block;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      
        <asp:Label ID="Label1" class="label" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" class="label" runat="server" Text="Credit Hours"></asp:Label>
        <asp:TextBox ID="Credit_hours" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" class="label" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="price" runat="server"></asp:TextBox>

        <br />
        <asp:Button ID="Button1" runat="server" Text="add" OnClick="addCourse" />

        <p>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </p>
        <p>
            &nbsp;</p>

    </form>
</body>
</html>
