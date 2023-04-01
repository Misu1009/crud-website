<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="WebCRUD.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="RegisterPage.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="backButton" runat="server" Text="<-" OnClick="backButton_Click"/><br /><br />

            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label><br />
            <asp:TextBox ID="nameTxtBox" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="emailTxtBox" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="passwordTxtBox" runat="server" TextMode="Password"></asp:TextBox><br /><br />

            <asp:Label ID="status" runat="server" Text=""></asp:Label><br />

            <asp:Button ID="registerButton" runat="server" Text="Register" OnClick="registerButton_Click" />
        </div>
    </form>
</body>
</html>
