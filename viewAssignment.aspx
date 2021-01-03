<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAssignment.aspx.cs" Inherits="Gucera.viewAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 620px;
            height: 350px;
            position: absolute;
            top: 209px;
            left: 51px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 108px;
            left: 106px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 146px;
            left: 109px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <h1> Assignment
    </h1>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="assignment" runat="server" CssClass="auto-style1">
        </asp:GridView>
        <p>
            Course ID
            <asp:TextBox ID="courseID" runat="server" CssClass="auto-style2" OnTextChanged="courseID_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="IDenter" runat="server" CssClass="auto-style3" Text="enter ID" OnClick="IDenter_Click" />
        </p>
    </form>
</body>
</html>
