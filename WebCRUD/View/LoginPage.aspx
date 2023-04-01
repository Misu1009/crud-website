<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebCRUD.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="LoginPage.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="email" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="emailTxtBox" runat="server"></asp:TextBox><br />

            <asp:Label ID="password" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="passwordTxtBox" runat="server" TextMode="Password"></asp:TextBox><br /><br />

            <asp:Label ID="status" runat="server" Text=""></asp:Label><br />

            <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" /><br /><br />
            <asp:Button ID="registerButton" runat="server" Text="Don't Have Account?" OnClick="registerButton_Click" /><br />

        </div>
    </form>
</body>
</html>
