<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorHome.aspx.cs" Inherits="Gucera.InstructorHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 666px;
        }
        #main_label{
            width : 40%;
            margin: 0 auto;
            font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
            text-align:center;
            font-size:2em;
            color:brown;
        }  
        .auto-style1 {
            position: absolute;
            top: 78px;
            left: 267px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div  id="main_label">
            Instructor Home
        </div>
        <asp:Button ID="Button1" runat="server" Text="add course" Width="208px" onclick="addCourse_click"/>
        <asp:Button ID="define_assigment" runat="server" Text="define assimgents" onclick="define_assigment_Click"/>
        <asp:Button ID="view_assigment" runat="server" Text="view assigments" onclick="view_assigment_Click"/>
        <asp:Button ID="grade_assigment" runat="server" Text="grade assigments" onclick="grade_assigment_Click"/>
        <asp:Button ID="view_feedback" runat="server" Text="view feedback" onclick="view_feedback_Click"/>
        <asp:Button ID="issue_certificate" runat="server" Text="issue certificate" onclick="issue_certificate_Click"/>
        <asp:Button ID="add_num" runat="server" CssClass="auto-style1" OnClick="add_num_Click" style="z-index: 1" Text="add mobile number" />
    </form>
</body>
</html>
