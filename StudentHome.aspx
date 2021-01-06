<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="Gucera.StudentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 87px;
            left: 263px;
            z-index: 1;
            width: 248px;
            height: 45px;
        }
        .auto-style2 {
            position: absolute;
            top: 158px;
            left: 264px;
            z-index: 1;
            width: 248px;
            height: 46px;
        }
        .auto-style3 {
            position: absolute;
            top: 240px;
            left: 267px;
            z-index: 1;
            width: 248px;
            height: 45px;
        }
        .auto-style4 {
            position: absolute;
            top: 307px;
            left: 265px;
            z-index: 1;
            width: 247px;
            height: 45px;
        }
        .auto-style5 {
            position: absolute;
            top: 384px;
            left: 265px;
            z-index: 1;
            width: 250px;
            height: 45px;
        }
        .auto-style6 {
            position: absolute;
            top: 88px;
            left: 551px;
            z-index: 1;
            width: 249px;
            height: 45px;
            bottom: 78px;
        }
        .auto-style7 {
            position: absolute;
            top: 157px;
            left: 550px;
            z-index: 1;
            width: 248px;
            height: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center" style="font-size: xx-large; font-family: 'Arial Black'; color: #000080;">
         Student Home
        </div>
        <asp:Button ID="viewMyProfile" runat="server" CssClass="auto-style1" ForeColor="#000099" Text="View my profile" OnClick="viewMyProfile_Click" />
        <asp:Button ID="viewAvailableCourses" runat="server" CssClass="auto-style2" ForeColor="#000099" Text="View Avaliable Courses" OnClick="viewAvailableCourses_Click" />
        <asp:Button ID="addCreditCard" runat="server" CssClass="auto-style3" ForeColor="#000099" OnClick="addCreditCard_Click" Text="Add Credit Card" />
        <asp:Button ID="viewAssignment" runat="server" CssClass="auto-style4" ForeColor="#000099" OnClick="viewAssignment_Click" Text="View Assignment" />

        <p>
            <asp:Button ID="submitAssignment" runat="server" CssClass="auto-style5" ForeColor="#000066" Text="Submit Assignment" OnClick="submitAssignment_Click" />
        </p>

        <asp:Button ID="viewPromocode" runat="server" CssClass="auto-style6" ForeColor="#000099" OnClick="viewPromocode_Click" Text="View Promocodes" />

        <asp:Button ID="enrollInCourse" runat="server" CssClass="auto-style7" ForeColor="#000099" OnClick="enrollInCourse_Click" Text="Enroll in Course" />
    </form>
</body>
</html>
