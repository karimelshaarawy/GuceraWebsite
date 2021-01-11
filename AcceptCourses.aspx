<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcceptCourses.aspx.cs" Inherits="Gucera.AcceptCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <h1>Accept Course</h1>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Admin ID"></asp:Label>
            <asp:TextBox ID="Txt1" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Course ID"></asp:Label>
        <asp:TextBox ID="Txt2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Accept" runat="server" OnClick="Accept_Click" Text="Accept" />
        </p>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
