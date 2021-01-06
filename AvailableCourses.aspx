<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AvailableCourses.aspx.cs" Inherits="Gucera.AvailableCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Courses</title>
    <style type="text/css">
        .auto-style1 {
            width: 391px;
            height: 220px;
            position: absolute;
            top: 89px;
            left: 10px;
            z-index: 1;
        }
    </style>
</head>
    <h1>Courses</h1>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style1" EmptyDataText="No Courses Available " ForeColor="#0000CC" Height="50px">
        </asp:GridView>
    </form>
</body>
</html>
