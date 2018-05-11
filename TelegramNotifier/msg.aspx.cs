using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelegramNotifier
{
    public partial class msg : DPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request["id"]))
            {
                Response.Redirect("login.aspx");
            }
            if (string.IsNullOrEmpty(Request["bid"]))
            {
                Response.Redirect("login.aspx");
            }
            var msg = Global.Role.GetQ<Models.MessageInfo>(Request["bid"] + "_MSGS").DataByKey(Request["id"]);

            if (msg != null) {
                Response.Write(msg.Content);
            }

        }



    }
}
