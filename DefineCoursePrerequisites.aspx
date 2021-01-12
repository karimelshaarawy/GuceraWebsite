<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefineCoursePrerequisites.aspx.cs" Inherits="Gucera.DefineCoursePrerequisites" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Course id"></asp:Label>
        <div>
        </div>
        <asp:TextBox ID="CourseId" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Prequisite id"></asp:Label>
        </p>
        <asp:TextBox ID="preqID" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="addPreq" runat="server" Text="Add" onclick="addPreq_Click" />
        </p>
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
