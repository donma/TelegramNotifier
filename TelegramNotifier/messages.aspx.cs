using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelegramNotifier
{
    public partial class messages : DPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request["id"]))
            {
                Response.Redirect("bots.aspx");
            }


            var msgs = Global.Role.GetQ<Models.MessageInfo>(Request["id"] + "_MSGS").AllDatasList();

            msgs = msgs.OrderByDescending(x => x.Stamp).ToList();

            foreach (var msg in msgs)
            {
                ltlMain.Text += " <tr><td><a href='msg.aspx?bid="+Request["id"]+"&id="+ msg.Id+"' target='_blank'>" +(msg.Content.Length>20? msg.Content.Substring(0,20)+"...": msg.Content )+ "</td><td>" + msg.Stamp.ToString("yyyy-MM-dd HH:mm:ss") + "</td>" +
                    "</tr>";
            }

        }
    }
}