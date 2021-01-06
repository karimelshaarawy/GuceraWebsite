<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAssignGrade.aspx.cs" Inherits="Gucera.view_assign_grade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 44px;
            left: 10px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 91px;
            left: 10px;
        }
        .auto-style3 {
            position: absolute;
            top: 127px;
            left: 10px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 44px;
            left: 134px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 91px;
            left: 136px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 131px;
            left: 131px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 175px;
            left: 18px;
            z-index: 1;
            width: 149px;
            right: 631px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="assignment type"></asp:Label>
            <asp:TextBox ID="assignmentType" runat="server" CssClass="auto-style4"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style2" style="z-index: 1" Text="assignment number"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style3" Text="Course ID"></asp:Label>
        <asp:TextBox ID="assignmentNumber" runat="server" CssClass="auto-style5"></asp:TextBox>
        <asp:TextBox ID="courseId" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Button ID="viewAssignmentGrade" runat="server" CssClass="auto-style7" Text="View Grade" OnClick="viewAssignmentGrade_Click" />
    </form>
</body>
</html>
