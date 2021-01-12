<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListAllCourses.aspx.cs" Inherits="Gucera.ListAllCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <h1>All Courses</h1>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="table1" runat="server" EmptyDataText="No Courses Found">
        </asp:GridView>
    </form>
</body>
</html>
