using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelegramNotifier
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admindisplay"] != null)
            {
                txtN1.Text = txtN2.Text = Session["admindisplay"].ToString();
            }
            else
            {
                Response.Redirect("logout.aspx");
            }
        }
    }
}