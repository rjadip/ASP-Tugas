<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPVOTING.Daftar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>
    <link href="../aset/css/admin/daftar.css" rel="stylesheet" />
</head>
<body>
    <h1>LOGIN</h1>
    <div id="main-container">
    <form id="form2" runat="server">   
        <asp:Label ID="statusmasuk" runat="server"></asp:Label>
        <br />
        <br /> 
        <asp:TextBox ID="username" runat="server" placeholder="Masukkan Username Anda"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="pass" runat="server" placeholder="Masukkan Password Anda" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="kirim1" runat="server" Text="Masuk" OnClick="kirim_Click" Width="291px" />
        <br />
        <br />
    </form>
     </div>
</body>
</html>
