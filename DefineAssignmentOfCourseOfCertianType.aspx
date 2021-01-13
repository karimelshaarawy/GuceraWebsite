<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefineAssignmentOfCourseOfCertianType.aspx.cs" Inherits="Gucera.DefineAssignmentOfCourseOfCertianType" %>

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
        <asp:Label ID="Label2" runat="server" Text="Type"></asp:Label>
        <p>
            <asp:TextBox ID="type" runat="server" MaxLength="10"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="number"></asp:Label>
        <p>
            <asp:TextBox ID="num" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label4" runat="server" Text="fullgrade"></asp:Label>
        <p>
            <asp:TextBox ID="fullgrade" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label5" runat="server" Text="deadline"></asp:Label>
        <p>
            <asp:TextBox ID="deadline" runat="server" TextMode="Date"></asp:TextBox>
        </p>
        <asp:Label ID="Label6" runat="server" Text="weight"></asp:Label>
        <p>
            <asp:TextBox ID="weight" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label7" runat="server" Text="content"></asp:Label>
        <p>
            <asp:TextBox ID="content" runat="server" MaxLength="200"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="defineAssigment" runat="server" Text="add" OnClick="defineAssigment_Click" />
        </p>
    </form>

    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
</body>
</html>
