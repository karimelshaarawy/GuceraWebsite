<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAnotherInstructorToCourse.aspx.cs" Inherits="Gucera.AddAnotherInstructorToCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="text-align:center;font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;font-size:2em">Add another instructor to the course</div>

        <p>
        <asp:Label ID="Label1" runat="server" Text="CourseId" style="display:block"></asp:Label>
         </p>
        <p>            
        <asp:TextBox ID="CourseId" runat="server" style="display:block"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Instructor id"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="newInstId" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addInstructorTocourse" runat="server" Text="add" onclick="addInstructorTocourse_Click" />
        </p>
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
