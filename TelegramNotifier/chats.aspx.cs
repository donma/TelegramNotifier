using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelegramNotifier
{
    public partial class chats : DPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request["id"]))
            {
                Response.Redirect("bots.aspx");
            }


            var chats = Global.Role.GetQ<Models.ChatUserInfo>(Request["id"] + "_USERS").AllDatasList();

            chats = chats.OrderByDescending(x => x.LastUpdate).ToList();

            foreach (var chat in chats)
            {
                ltlMain.Text += " <tr><td>" + chat.FirstName + "</td><td>" + chat.LastName + "</td><td>" + (chat.IsStopNoti ? "<span class='badge bg-red'>否</span>" : "<span class='badge bg-green'>是</span>") + "</td><td>" + chat.LastUpdate.ToString("yyyy-MM-dd HH:mm:ss") + "</td>" +
                    "</tr>";
            }

        }
    }
}