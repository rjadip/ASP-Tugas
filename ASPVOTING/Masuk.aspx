<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Masuk.aspx.cs" Inherits="ASPVOTING.Masuk" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Daftar</title>
    <link href="aset/css/daftar.css" rel="stylesheet" />
</head>
<body>
    <h1>Masuk Untuk Voting</h1>
    <div id="main-container">
    <form id="form1" runat="server">    
        <asp:Label ID="statusmasuk" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
        <br />
        <asp:TextBox ID="nama" runat="server" placeholder="Masukkan Nama Anda"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="tempatlahir" runat="server" placeholder="Masukkan Tempat Lahir Anda"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="Tanggallahir" runat="server" placeholder="Masukkan Tanggal Lahir Anda" TextMode="DateTime" ValidationExpression="(((0|1)[1-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"
    ErrorMessage="Invalid date format."></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="kirim" runat="server" Text="Masuk" OnClick="kirim_Click" />
        <br />
        <br />
    </form>
     </div>
</body>
</html>
