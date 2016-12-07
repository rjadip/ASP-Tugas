<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPVOTING.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>HALAMAN UTAMA</title>
    <link href="aset/css/default.css" rel="stylesheet" />
</head>
<body>
    <div id="outer-wrapper">
    <form id="form1" runat="server">
        <div id="centering">
            Terima Kasih, <asp:Label ID="username" runat="server" Text="Label"></asp:Label>. Anda telah melakukan voting.
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
    </form>
    </div>
</body>
</html>