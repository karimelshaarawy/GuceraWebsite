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
        .auto-style8 {
            position: absolute;
            top: 241px;
            left: 554px;
            z-index: 1;
            width: 249px;
            height: 45px;
        }
        .auto-style9 {
            position: absolute;
            top: 307px;
            left: 559px;
            z-index: 1;
            width: 249px;
            height: 46px;
        }
        .auto-style10 {
            position: absolute;
            top: 386px;
            left: 555px;
            z-index: 1;
            width: 250px;
            height: 45px;
        }
        .auto-style11 {
            position: absolute;
            top: 447px;
            left: 264px;
            z-index: 1;
            width: 250px;
            height: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center" style="font-size: xx-large; font-family: 'Arial Black'; color: #000080;">
            <asp:Button ID="listCertificates" runat="server" CssClass="auto-style10" ForeColor="#000099" Text="List Certificates" OnClick="listCertificates_Click" />
         Student Home
        </div>
        <asp:Button ID="viewMyProfile" runat="server" CssClass="auto-style1" ForeColor="#000099" Text="View my profile" OnClick="viewMyProfile_Click" />
        <asp:Button ID="viewAvailableCourses" runat="server" CssClass="auto-style2" ForeColor="#000099" Text="View Avaliable Courses" OnClick="viewAvailableCourses_Click" />
        <asp:Button ID="addCreditCard" runat="server" CssClass="auto-style3" ForeColor="#000099" OnClick="addCreditCard_Click" Text="Add Credit Card" />
        <asp:Button ID="addFeedback" runat="server" CssClass="auto-style9" ForeColor="#000099" Text="Add Feedback" OnClick="addFeedback_Click" />
        <asp:Button ID="viewAssignment" runat="server" CssClass="auto-style4" ForeColor="#000099" OnClick="viewAssignment_Click" Text="View Assignment" />

        <asp:Button ID="AddTelephoneNumber" runat="server" CssClass="auto-style11" ForeColor="#000099" Text="Add Telephone Number" OnClick="AddTelephoneNumber_Click" />

        <p>
            <asp:Button ID="submitAssignment" runat="server" CssClass="auto-style5" ForeColor="#000066" Text="Submit Assignment" OnClick="submitAssignment_Click" />
        </p>

        <asp:Button ID="viewPromocode" runat="server" CssClass="auto-style6" ForeColor="#000099" OnClick="viewPromocode_Click" Text="View Promocodes" />

        <asp:Button ID="enrollInCourse" runat="server" CssClass="auto-style7" ForeColor="#000099" OnClick="enrollInCourse_Click" Text="Enroll in Course" />
        <p>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style8" ForeColor="#000099" OnClick="Button1_Click" Text="View Assignment Grade" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
