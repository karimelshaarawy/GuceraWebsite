<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreditCard.aspx.cs" Inherits="Gucera.CreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Credit Card</title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 70px;
            left: 148px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 108px;
            left: 147px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 146px;
            left: 149px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 184px;
            left: 148px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 244px;
            left: 115px;
            z-index: 1;
            width: 70px;
        }
    </style>
</head>
    <h1>Add Credit Card</h1>
<body>
    <form id="form1" runat="server">
        <div>
            Credit card number
            <asp:TextBox ID="number" runat="server" CssClass="auto-style1"></asp:TextBox>
            <br />
            <br />
            Card holder name
            <asp:TextBox ID="holderName" runat="server" CssClass="auto-style2"></asp:TextBox>
            <br />
            <br />
            Expiry date (Y/M/D)<asp:TextBox ID="date" runat="server" CssClass="auto-style3"></asp:TextBox>
            <br />
            <br />
            CVV
            <asp:TextBox ID="cvv" runat="server" CssClass="auto-style4"></asp:TextBox>
        </div>
        <asp:Button ID="AddCreditCard" runat="server" CssClass="auto-style5" ForeColor="#000099" Text="Add" OnClick="AddCreditCard_Click" />
    </form>
</body>
</html>
