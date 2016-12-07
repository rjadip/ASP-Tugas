<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPVOTING.admin.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>VOTE NOW</title>
    <link href="../aset/css/admin/default.css" rel="stylesheet" />
</head>
<body>
    <div id="outer-wrapper">
    <form id="form1" runat="server">
    <header>
        <div id="container">
            <h1>HALAMAN UTAMA</h1>
        </div>
    </header>
    
    <div id="container-wrapper">
            <div id="konfirmasi">
                Selamat Datang, 
                <asp:Label ID="username" runat="server"></asp:Label>.
                Terima kasih telah memilih. <a href="logout.aspx">Keluar</a>
            </div>
            <div id="main-container">
                <div id="container-left">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="EntityDataSource3" AllowSorting="True" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                        <Columns>
                            <asp:BoundField DataField="team_name" HeaderText="team_name" SortExpression="team_name" ReadOnly="True" />
                            <asp:BoundField DataField="jumlah_pemilih" HeaderText="jumlah_pemilih" SortExpression="jumlah_pemilih" ReadOnly="True" />
                            <asp:BoundField DataField="total_pemilih" HeaderText="total_pemilih" ReadOnly="True" SortExpression="total_pemilih" />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#333333" />
                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#487575" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#275353" />
                    </asp:GridView>
                    <asp:EntityDataSource ID="EntityDataSource3" runat="server" ConnectionString="name=votingEntitiesFinishing" DefaultContainerName="votingEntitiesFinishing" EnableFlattening="False" EntitySetName="tb_team" Select="it.[team_name], it.[jumlah_pemilih], it.[total_pemilih]">
                    </asp:EntityDataSource>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:votingConnectionString2 %>" SelectCommand="SELECT [team_name], [jumlah_pemilih] FROM [tb_team]"></asp:SqlDataSource>
                    <br />
                    <br />
                </div>

                <div id="container-right">
                    <div id="user-login">
                        <h2>Info User</h2>
                        <p>
                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="EntityDataSource4">
                                <Columns>
                                    <asp:BoundField DataField="admin_name" HeaderText="admin_name" ReadOnly="True" SortExpression="admin_name" />
                                    <asp:BoundField DataField="admin_username" HeaderText="admin_username" ReadOnly="True" SortExpression="admin_username" />
                                    <asp:BoundField DataField="admin_level" HeaderText="admin_level" ReadOnly="True" SortExpression="admin_level" />
                                </Columns>
                            </asp:GridView>
                            <asp:EntityDataSource ID="EntityDataSource4" runat="server" ConnectionString="name=votingEntitiesFinishing" DefaultContainerName="votingEntitiesFinishing" EnableFlattening="False" EntitySetName="tb_admin" Select="it.[admin_name], it.[admin_username], it.[admin_level]">
                            </asp:EntityDataSource>
                        </p>
                    </div>
                    <div id="tambahuser">
                        <h1>+User Baru</h1>
                        <asp:Label ID="statusmessage" CssClass="statusmessage" runat="server"></asp:Label>
                        <br />
                        <br />
                        <asp:TextBox ID="adminname" runat="server" placeholder="Masukkan Nama Lengkap"></asp:TextBox>
                        <br />
                        <br />
                        <asp:TextBox ID="adminusername" runat="server" placeholder="Masukkan Username"></asp:TextBox>
                        <br />
                        <br />
                        <asp:TextBox type="password" ID="adminpassword" runat="server" placeholder="Masukkan Password"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="tambahsekarang" runat="server" Text="Button" OnClick="tambahsekarang_Click" />
                    </div>
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