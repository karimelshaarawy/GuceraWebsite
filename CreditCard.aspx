<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreditCard.aspx.cs" Inherits="Gucera.CreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Credit Card</title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 221px;
            left: 151px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 260px;
            left: 151px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 296px;
            left: 151px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 333px;
            left: 148px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 403px;
            left: 110px;
            z-index: 1;
            width: 70px;
        }
        .auto-style6 {
            position: absolute;
            top: 360px;
            left: 51px;
            z-index: 1;
            width: 290px;
        }
    </style>
</head>
    <h1>&nbsp;</h1>
<h1>Add Credit Card</h1>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            Credit card number
            <asp:TextBox ID="number" runat="server" CssClass="auto-style1"></asp:TextBox>
            <br />
            <br />
            Card holder name
            <asp:TextBox ID="holderName" runat="server" CssClass="auto-style2"></asp:TextBox>
            <br />
            <br />
            Expiry date (Y/M/D)<asp:TextBox ID="date" runat="server" CssClass="auto-style3" TextMode="Date"></asp:TextBox>
            <br />
            <br />
            CVV
            <asp:TextBox ID="cvv" runat="server" CssClass="auto-style4" MaxLength="3"></asp:TextBox>
        </div>
        <asp:Button ID="AddCreditCard" runat="server" CssClass="auto-style5" ForeColor="#000099" Text="Add" OnClick="AddCreditCard_Click" />
        <asp:Label ID="Label1" runat="server" CssClass="auto-style6" ForeColor="Red" Text=""></asp:Label>
    </form>
</body>
</html>
