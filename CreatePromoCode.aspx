<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePromoCode.aspx.cs" Inherits="Gucera.CreatePromoCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <h1>Create Promo Code</h1>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="code" runat="server" Text="Code"></asp:Label>
            <asp:TextBox ID="Txt1" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="issue" runat="server" Text="issue date(Y/M/D)"></asp:Label>
        <asp:TextBox ID="Txt2" runat="server" TextMode="Date"></asp:TextBox>
        <p>
            <asp:Label ID="expiry" runat="server" Text="expiry date(Y/M/D)"></asp:Label>
            <asp:TextBox ID="Txt3" runat="server" TextMode="Date"></asp:TextBox>
        </p>
        <asp:Label ID="discount" runat="server" Text="discount"></asp:Label>
        <asp:TextBox ID="Txt4" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="id" runat="server" Text="admin id"></asp:Label>
            <asp:TextBox ID="Txt5" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="create" runat="server" Text="Create" OnClick="create_Click" />
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
