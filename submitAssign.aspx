<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="submitAssign.aspx.cs" Inherits="Gucera.submitAssign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 34px;
            left: 10px;
        }
        .auto-style2 {
            position: absolute;
            top: 158px;
            left: 14px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 91px;
            left: 10px;
            z-index: 1;
            margin-bottom: 25px;
        }
        .auto-style4 {
            position: absolute;
            top: 128px;
            left: 10px;
            z-index: 1;
            height: 21px;
        }
        .auto-style5 {
            position: absolute;
            top: 203px;
            left: 12px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            assignment type</div>
        <asp:TextBox ID="assignmentType" runat="server" CssClass="auto-style1" style="z-index: 1" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <p>
            assignment number</p>
        <asp:TextBox ID="assignmentNumber" runat="server" CssClass="auto-style3"></asp:TextBox>
        <asp:Button ID="submitButton" runat="server" CssClass="auto-style5" Text="submit Assignment" OnClick="submitButton_Click" />
        <p>
            <asp:TextBox ID="courseId" runat="server" CssClass="auto-style2"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Course ID"></asp:Label>
    </form>
</body>
</html>
