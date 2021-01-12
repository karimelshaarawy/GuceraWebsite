<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorgradeAssignmentOfAStudent.aspx.cs" Inherits="Gucera.InstructorgradeAssignmentOfAStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="student id"></asp:Label>
        <p>
            <asp:TextBox ID="StudentId" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="course id"></asp:Label>
        <p>
            <asp:TextBox ID="CourseId" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="assigment number"></asp:Label>
        <p>
            <asp:TextBox ID="assigmentNumber" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label4" runat="server" Text="assigment type"></asp:Label>
        <p>
            <asp:TextBox ID="assigmentType" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label5" runat="server" Text="grade"></asp:Label>
        <p>
            <asp:TextBox ID="gradeNum" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="grade" runat="server" OnClick="grade_Click" Text="grade" />
        <p>
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
