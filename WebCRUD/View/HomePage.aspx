<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebCRUD.View.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="HomePage.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>WELCOME TO THIS WEBSITE</h1><br />

            <asp:Button ID="listUseButtonr" runat="server" Text="List Of User" OnClick="listUserButton_Click" />
        </div>
    </form>
</body>
</html>
