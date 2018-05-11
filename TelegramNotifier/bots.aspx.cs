using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelegramNotifier
{
    public partial class bots : DPage
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            ltlMain.Text = "";

            var bots = Global.Role.GetQ<Models.BotInfo>("BOTS").AllDatasList();

            bots = bots.OrderByDescending(x => x.LastUpdate).ToList();

            foreach (var bot in bots)
            {
                ltlMain.Text += 
                    "<tr>" +
                    "<th>" + bot.Title + "</th>" +
                    "<th>" + bot.BroadcastToken + "</th>" +
                    "<th><a href='chats.aspx?id="+bot.Id+"'>" + Global.Role.GetQ<Models.ChatUserInfo>(bot.Id + "_USERS").DataCount() + "</a></th>" +
                    "<th><a href='messages.aspx?id=" + bot.Id + "'>" + Global.Role.GetQ<Models.ChatUserInfo>(bot.Id + "_MSGS").DataCount() + "</a></th>" +
                    "<th>" + bot.LastUpdate.ToString("yyyy-MM-dd HH:mm:ss") + "</th>" +
                    "<th><a href='bot.aspx?id="+bot.Id+"' class='badge bg-red'><i class='fa fa-chevron-circle-right' aria-hidden='true'></i>&nbsp;查看</a></th>" +
                    "</tr>";
            }
        }
    }
}