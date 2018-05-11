using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelegramNotifier.api
{
    public partial class push : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string id = Request.Form["id"];
            if (string.IsNullOrEmpty(id))
            {
                Response.Write("error:null id.");
                return;
            }

            string token = Request.Form["token"];

            if (string.IsNullOrEmpty(token))
            {
                Response.Write("error:null token.");
                return;
            }

            string content = Request.Form["content"];
            if (string.IsNullOrEmpty(content))
            {
                Response.Write("error:null content.");
                return;
            }


            var botInfo = Global.Role.GetQ<Models.BotInfo>("BOTS").DataByKey(Request["id"]);

            if (botInfo == null)
            {
                Response.Write("error:bot not existed.");
                return;
            }

            if (botInfo.BroadcastToken != token)
            {
                Response.Write("error:token error.");
                return;
            }

            var chats = Global.Role.GetQ<Models.ChatUserInfo>(Request["id"] + "_USERS").AllDatasList();

            foreach (var chat in chats)
            {

                if (!chat.IsStopNoti)
                {
                    if (content.Length <= 2000)
                    {


                        Global.Bots[id].SendTextMessageAsync(chat.Id, Server.HtmlDecode(content), Telegram.Bot.Types.Enums.ParseMode.Default);

                    }
                    else
                    {
                        var p = Global.Split(content, 2000);

                        foreach (var t in p)
                        {
                            Global.Bots[id].SendTextMessageAsync(chat.Id, Server.HtmlDecode(t), Telegram.Bot.Types.Enums.ParseMode.Html);
                            System.Threading.Thread.Sleep(491);
                        }

                    }
                }

            }

            var backup = new Models.MessageInfo();
            backup.Id = DateTime.Now.Ticks + "";
            backup.Content = content;
            backup.Stamp = DateTime.Now;
            Global.Role.GetOp(Request["id"] + "_MSGS").Update(backup.Id + "", backup);
        }


      



    }
}