<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="Gucera.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <h1>Admin Home</h1>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="ListAllCourses" runat="server" OnClick="ListAllCourse_Click" Text="View All Courses" />
        <asp:Button ID="ListAllNonAcceptedCourses" runat="server" OnClick="ListAllNonAcceptedCourses_Click" Text="View Non Accepted Courses" />
        <asp:Button ID="AcceptCourses" runat="server" OnClick="AcceptCourses_Click" Text="Accept Course" /> 
        <asp:Button ID="CreatePromoCode" runat="server" OnClick="CreatePromoCode_Click" Text="Create PromoCode" />
        <asp:Button ID="IssuePromoCode" runat="server" OnClick="IssuePromoCode_Click" Text="Issue PromoCode" />
        <p>
            <asp:Button ID="MobileNo" runat="server" OnClick="AddMobileNumber_Click" Text="addMobileNumber" />
        </p>
    </form>
</body>
</html>
