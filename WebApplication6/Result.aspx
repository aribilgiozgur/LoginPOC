<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="WebApplication6.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label><br />
        <asp:LinkButton ID="lnkEndSession" runat="server" OnClick="lnkEndSession_Click">Çıkış Yap</asp:LinkButton>
    </div>
    </form>
</body>
</html>
