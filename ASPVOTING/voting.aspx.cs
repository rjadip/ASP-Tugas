using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ASPVOTING
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=voting;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["namasudahada"] != null)
            {
                Response.Redirect("/");
            }
            else if (Session["namavoters"] == null)
            {
                Response.Redirect("WebForm1.aspx");
            }
            String user = Convert.ToString(Session["namavoters"]);
            String tempat = Convert.ToString(Session["tempatlahir"]);
            String tanggal = Convert.ToString(Session["tanggallahir"]);

            username.Text = user;
            tanggallahir.Text = tanggal;
            tempatlahir.Text = tempat;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.BufferOutput = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tb_user VALUES ('" + username.Text + "', '" + tempatlahir.Text + "', '" + tanggallahir.Text + "')", con);
            SqlCommand cmdt = new SqlCommand("UPDATE tb_team SET jumlah_pemilih = jumlah_pemilih+1 WHERE team_id=1", con);
            SqlCommand cmdtp = new SqlCommand("UPDATE tb_team SET total_pemilih = total_pemilih+1", con);
            cmd.ExecuteNonQuery();
            cmdt.ExecuteNonQuery();
            cmdtp.ExecuteNonQuery();
            Session["namasudahada"] = username.Text;
            Response.Redirect("Masuk.aspx");
            //Server.Transfer("Masuk.aspx", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tb_user VALUES ('" + username.Text + "', '" + tanggallahir.Text + "', '" + tempatlahir + "')", con);
            SqlCommand cmdt = new SqlCommand("UPDATE tb_team SET jumlah_pemilih = jumlah_pemilih+1 WHERE team_id=2", con);
            SqlCommand cmdtp = new SqlCommand("UPDATE tb_team SET total_pemilih = total_pemilih+1", con);
            cmd.ExecuteNonQuery();
            cmdt.ExecuteNonQuery();
            cmdtp.ExecuteNonQuery();
            Session["namasudahada"] = username.Text;
            Response.Redirect("masuk.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tb_user VALUES ('" + username.Text + "', '" + tanggallahir.Text + "', '" + tempatlahir + "')", con);
            SqlCommand cmdt = new SqlCommand("UPDATE tb_team SET jumlah_pemilih = jumlah_pemilih+1 WHERE team_id=3", con);
            SqlCommand cmdtp = new SqlCommand("UPDATE tb_team SET total_pemilih = total_pemilih+1", con);
            cmd.ExecuteNonQuery();
            cmdt.ExecuteNonQuery();
            cmdtp.ExecuteNonQuery();
            Session["namasudahada"] = username.Text;
            Response.Redirect("masuk.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tb_user VALUES ('" + username.Text + "', '" + tanggallahir.Text + "', '" + tempatlahir + "')", con);
            SqlCommand cmdt = new SqlCommand("UPDATE tb_team SET jumlah_pemilih = jumlah_pemilih+1 WHERE team_id=4", con);
            SqlCommand cmdtp = new SqlCommand("UPDATE tb_team SET total_pemilih = total_pemilih+1", con);
            cmd.ExecuteNonQuery();
            cmdt.ExecuteNonQuery();
            cmdtp.ExecuteNonQuery();
            Session["namasudahada"] = username.Text;
            Response.Redirect("masuk.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tb_user VALUES ('" + username.Text + "', '" + tanggallahir.Text + "', '" + tempatlahir + "')", con);
            SqlCommand cmdt = new SqlCommand("UPDATE tb_team SET jumlah_pemilih = jumlah_pemilih+1 WHERE team_id=5", con);
            SqlCommand cmdtp = new SqlCommand("UPDATE tb_team SET total_pemilih = total_pemilih+1", con);
            cmd.ExecuteNonQuery();
            cmdt.ExecuteNonQuery();
            cmdtp.ExecuteNonQuery();
            Session["namasudahada"] = username.Text;
            Response.Redirect("masuk.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tb_user VALUES ('" + username.Text + "', '" + tanggallahir.Text + "', '" + tempatlahir + "')", con);
            SqlCommand cmdt = new SqlCommand("UPDATE tb_team SET jumlah_pemilih = jumlah_pemilih+1 WHERE team_id=6", con);
            SqlCommand cmdtp = new SqlCommand("UPDATE tb_team SET total_pemilih = total_pemilih+1", con);
            cmd.ExecuteNonQuery();
            cmdt.ExecuteNonQuery();
            cmdtp.ExecuteNonQuery();
            Session["namasudahada"] = username.Text;
            Response.Redirect("masuk.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tb_user VALUES ('" + username.Text + "', '" + tanggallahir.Text + "', '" + tempatlahir + "')", con);
            SqlCommand cmdt = new SqlCommand("UPDATE tb_team SET jumlah_pemilih = jumlah_pemilih+1 WHERE team_id=7", con);
            SqlCommand cmdtp = new SqlCommand("UPDATE tb_team SET total_pemilih = total_pemilih+1", con);
            cmd.ExecuteNonQuery();
            cmdt.ExecuteNonQuery();
            cmdtp.ExecuteNonQuery();
            Session["namasudahada"] = username.Text;
            Response.Redirect("masuk.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tb_user VALUES ('" + username.Text + "', '" + tanggallahir.Text + "', '" + tempatlahir + "')", con);
            SqlCommand cmdt = new SqlCommand("UPDATE tb_team SET jumlah_pemilih = jumlah_pemilih+1 WHERE team_id=8", con);
            SqlCommand cmdtp = new SqlCommand("UPDATE tb_team SET total_pemilih = total_pemilih+1", con);
            cmd.ExecuteNonQuery();
            cmdt.ExecuteNonQuery();
            cmdtp.ExecuteNonQuery();
            Session["namasudahada"] = username.Text;
            Response.Redirect("masuk.aspx");
        }
    }
}