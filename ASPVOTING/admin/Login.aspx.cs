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
    public partial class Daftar : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=voting;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Response.Redirect("/admin/");
            }
        }

        protected void kirim_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                statusmasuk.Text = "Maaf, Username Tidak Boleh Kosong";
            }
            else
            {
                if (pass.Text == "")
                {
                    statusmasuk.Text = "Maaf, Password Tidak Boleh Kosong";
                }
                else{
                
                        con.Open();
                        string cekpassword = "select count(*) from tb_admin where admin_password='" + pass.Text + "'and admin_username='" + username.Text + "'";
                        SqlCommand passcom = new SqlCommand(cekpassword, con);
                        int password = Convert.ToInt32(passcom.ExecuteScalar());

                        if (password == 1)
                        {
                            Session["username"] = username.Text;
                            Response.Redirect("/admin/");
                        }
                        else
                        {
                            statusmasuk.Text = "Username Atau Password Salah";
                        }
                }
            }
        }
    }
}