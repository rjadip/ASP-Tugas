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

    public partial class Masuk : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=voting;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["namasudahada"] != null)
            {
                Response.Redirect("/");
            }
        }

        protected void kirim_Click(object sender, EventArgs e)
        {

            if (nama.Text == "")
            {
                statusmasuk.Text = "Maaf, Username Tidak Boleh Kosong";
            }
            else
            {
                if (tempatlahir.Text == "")
                {
                    statusmasuk.Text = "Maaf, Password Tidak Boleh Kosong";
                }
                else
                {
                    if (Tanggallahir.Text == "")
                    {
                        statusmasuk.Text = "Maaf, Tanggal Lahir Tidak Boleh Kosong";
                    }
                    else
                    {
                        con.Open();
                        string cekuser = "select count(*) from tb_user where user_name='" + nama.Text + "'";

                        SqlCommand com = new SqlCommand(cekuser, con);
                        int temp = Convert.ToInt32(com.ExecuteScalar());
                        con.Close();
                        if (temp == 1)
                        {
                            con.Open();
                            string cekpassword = "select count(*) from tb_user where user_tempat_lahir='" + tempatlahir.Text + "'and user_name='" + nama.Text + "' and user_tanggal_lahir='" + Tanggallahir.Text + "'";
                            SqlCommand passcom = new SqlCommand(cekpassword, con);
                            int password = Convert.ToInt32(passcom.ExecuteScalar());

                            if (password >= 1)
                            {
                                Session["namasudahada"] = nama.Text;
                                Response.Redirect("/");
                            }
                            else
                            {
                                Session["namavoters"] = nama.Text;
                                Session["tempatlahir"] = tempatlahir.Text;
                                Session["tanggallahir"] = Tanggallahir.Text;
                                Response.Redirect("/voting.aspx");
                            }
                        }
                        else
                        {
                            Session["namavoters"] = nama.Text;
                            Session["tempatlahir"] = tempatlahir.Text;
                            Session["tanggallahir"] = Tanggallahir.Text;
                            Response.Redirect("/voting.aspx");
                        }
                    }
                }
            }
        }

    }
}