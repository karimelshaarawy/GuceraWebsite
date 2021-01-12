<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorIssueCertificateToStudent.aspx.cs" Inherits="Gucera.InstructorIssueCertificateToStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Course ID"></asp:Label>
        </div>
        <asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Student ID"></asp:Label>
        </div>
        <asp:TextBox ID="StudentID" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Issue" runat="server" Text="Issue certificate" OnClick="Issue_Click" />
        </p>
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
