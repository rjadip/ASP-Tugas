using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ASPVOTING.admin
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=voting;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("/admin/Login.aspx");
            }
        }

        protected void tambahsekarang_Click(object sender, EventArgs e)
        {
            if (adminname.Text == "")
            {
                statusmessage.Text = "Maaf, Nama Admin Tidak Boleh Kosong";
            }
            else
            {
                if (adminusername.Text == "")
                {
                    statusmessage.Text = "Maaf, Username Admin Tidak Boleh Kosong";
                }
                else
                {
                    if (adminpassword.Text == "")
                    {
                        statusmessage.Text = "Maaf, Kolom Password Tidak Boleh Kosong";
                    }
                    else
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO tb_admin VALUES ('" + adminname.Text + "', '" + adminusername.Text + "','" + adminpassword.Text + "','user' )", con);
                        cmd.ExecuteNonQuery();
                        statusmessage.Text = "Data Berhasil Di Tambahkan";
                    }
                }
            }
        }
    }
}