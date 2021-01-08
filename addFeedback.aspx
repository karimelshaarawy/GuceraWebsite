<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addFeedback.aspx.cs" Inherits="Gucera.addFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 45px;
            left: 142px;
            z-index: 1;
            width: 242px;
            height: 79px;
        }
        .auto-style2 {
            position: absolute;
            top: 47px;
            left: 10px;
            z-index: 1;
            width: 90px;
        }
        .auto-style3 {
            position: absolute;
            top: 156px;
            left: 141px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 157px;
            left: 10px;
            z-index: 1;
            width: 90px;
        }
        .auto-style5 {
            position: absolute;
            top: 202px;
            left: 14px;
            z-index: 1;
            width: 131px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style5" ForeColor="#000099" Text="Submit Feedback" OnClick="Button1_Click" />
        <asp:TextBox ID="comment" runat="server" CssClass="auto-style1"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="Comment"></asp:Label>
        <asp:TextBox ID="courseId" runat="server" CssClass="auto-style3" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style4" Text="Course ID"></asp:Label>
    </form>
</body>
</html>
