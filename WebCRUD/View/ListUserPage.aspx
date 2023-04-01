﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListUserPage.aspx.cs" Inherits="WebCRUD.View.ListUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="ListUserPage.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="backButton" runat="server" Text="<-" OnClick="back_Click"/><br />
            <asp:Label ID="status" runat="server" Text=""></asp:Label>

            <asp:GridView ID="userGridView" runat="server" OnRowDeleting="userGridView_RowDeleting" AutoGenerateDeleteButton> </asp:GridView><br />
        </div>
    </form>
</body>
</html>