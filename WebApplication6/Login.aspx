<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication6.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Kullanıcı Adı: <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
        Şifre:<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Gönder" OnClick="btnSubmit_Click" />

        <asp:Label ID="lblError" runat="server" Text="HATA!" Visible="false"></asp:Label>

    </div>
    </form>
</body>
</html>
