<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="voting.aspx.cs" Inherits="ASPVOTING.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VOTE NOW</title>
    <link href="aset/css/voting.css" rel="stylesheet" />
</head>
<body>
    <div id="outer-wrapper">
    <form id="form1" runat="server">
    <header>
        <div id="container">
            <h1>VOTE NOW</h1>
        </div>
    </header>
    
    <div id="container-wrapper">
            <div id="konfirmasi">
                Selamat Datang, 
                <asp:Label ID="username" runat="server"></asp:Label>. Tempat Lahir: 
                <asp:Label ID="tempatlahir" runat="server"></asp:Label>
                , Tanggal Lahir Anda: 
                <asp:Label ID="tanggallahir" runat="server"></asp:Label>
                , Silahkan berikan pilihan Anda.
            </div>
           <div id="main-container">
               <div class="user">
                   <h3>Bill Gates</h3>
                   <img src="Images/1.jpg" />
                   <asp:Button CssClass="votenow" ID="Button1" runat="server" Text="Vote Now" OnClick="Button1_Click" />
               </div>

               <div class="user">
                   <h3>My Hero</h3>
                   <img src="Images/2.jpg" />
                   <asp:Button CssClass="votenow" ID="Button2" runat="server" Text="Vote Now" OnClick="Button2_Click" />
               </div>

               <div class="user">
                   <h3>Pak Zyad</h3>
                   <img src="Images/3.jpeg" />
                   <asp:Button CssClass="votenow" ID="Button3" runat="server" Text="Vote Now" OnClick="Button3_Click" />
               </div>

               <div class="user">
                   <h3>Absurd</h3>
                   <img src="Images/4.jpg" />
                   <asp:Button CssClass="votenow" ID="Button4" runat="server" Text="Vote Now" OnClick="Button4_Click" />
               </div>

               <div class="user">
                   <h3>Hot Babes</h3>
                   <img src="Images/5.jpg" />
                   <asp:Button CssClass="votenow" ID="Button5" runat="server" Text="Vote Now" OnClick="Button5_Click" />
               </div>

               <div class="user">
                   <h3>Cantik</h3>
                   <img src="Images/9.jpg" />
                   <asp:Button CssClass="votenow" ID="Button6" runat="server" Text="Vote Now" OnClick="Button6_Click" />
               </div>

               <div class="user">
                   <h3>DUIT</h3>
                   <img src="Images/7a.jpg" />
                   <asp:Button CssClass="votenow" ID="Button7" runat="server" Text="Vote Now" OnClick="Button7_Click" />
               </div>

               <div class="user">
                   <h3>Ganteng</h3>
                   <img src="Images/8.jpg" />
                   <asp:Button CssClass="votenow" ID="Button8" runat="server" Text="Vote Now" OnClick="Button8_Click" />
               </div>
           </div>
        </div>

        <footer id="outer-footer">
            <div id="container">
                Copyright &copy; 2016 Votingers. AllRights Reserverd
            </div>
        </footer>
    </form>
    </div>
</body>
</html>
