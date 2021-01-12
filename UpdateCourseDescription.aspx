<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCourseDescription.aspx.cs" Inherits="Gucera.UpdateCourseDescription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Course id"></asp:Label>
        <p>
            <asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:TextBox ID="description" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Update" onclick="updateDescription_Click"/>
        <p>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
