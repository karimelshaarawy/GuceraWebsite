<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="submitAssign.aspx.cs" Inherits="Gucera.submitAssign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 27px;
            left: 149px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 110px;
            left: 148px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 68px;
            left: 146px;
            z-index: 1;
            margin-bottom: 25px;
        }
        .auto-style4 {
            position: absolute;
            top: 113px;
            left: 15px;
            z-index: 1;
            height: 21px;
        }
        .auto-style5 {
            position: absolute;
            top: 159px;
            left: 13px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 69px;
            left: 10px;
            z-index: 1;
            width: 125px;
        }
        .auto-style7 {
            position: absolute;
            top: 34px;
            left: 10px;
            z-index: 1;
            width: 126px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" CssClass="auto-style7" Text="assignment type"></asp:Label>
        </div>
        <asp:TextBox ID="assignmentType" runat="server" CssClass="auto-style1" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" CssClass="auto-style6" Text="assignment number"></asp:Label>
        </p>
        <asp:TextBox ID="assignmentNumber" runat="server" CssClass="auto-style3"></asp:TextBox>
        <p>
            <asp:TextBox ID="courseId" runat="server" CssClass="auto-style2"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Course ID"></asp:Label>
        <p>
        <asp:Button ID="submitButton" runat="server" CssClass="auto-style5" Text="submit Assignment" OnClick="submitButton_Click" />
        </p>
    </form>
</body>
</html>
