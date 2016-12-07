using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVOTING
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["namasudahada"] == null)
            {
                Response.Redirect("Masuk.aspx");
            }
            String namasudahada = Convert.ToString(Session["namasudahada"]);
            username.Text = namasudahada;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["namasudahada"] = null;
            Response.Redirect("Masuk.aspx");
        }
    }
}