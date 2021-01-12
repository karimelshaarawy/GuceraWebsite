<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorViewAssignmentsStudents.aspx.cs" Inherits="Gucera.InstructorViewAssignmentsStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Course ID"></asp:Label>
        <p>
            <asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="showTable" runat="server" Text="View" OnClick="showTable_Click" />
       <p>
           <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
       </p> 
        <asp:GridView ID="Assigment" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
