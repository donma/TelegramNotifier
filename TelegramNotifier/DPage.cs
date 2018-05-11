using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace TelegramNotifier
{
    public class DPage : Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {

            if (Session["admin"] != null && Session["admindisplay"] != null)
            {

            }
            else
            {
                Response.Redirect("login.aspx?msg=無登入資訊&tf=" + Server.UrlEncode(Request.Url.AbsoluteUri));
            }
        }
    }
}