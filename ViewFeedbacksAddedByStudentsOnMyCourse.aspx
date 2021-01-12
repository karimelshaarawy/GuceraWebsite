<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewFeedbacksAddedByStudentsOnMyCourse.aspx.cs" Inherits="Gucera.ViewFeedbacksAddedByStudentsOnMyCourse" %>

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
        <asp:TextBox ID="CourseId" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="View" runat="server" Text="View Feedback" OnClick="View_Click" />
        </p>
        <asp:GridView ID="Feedback" runat="server">
        </asp:GridView>
        <p>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
