using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Telegram.Bot;
using Telegram.Bot.Types.InputFiles;

namespace TelegramNotifier
{
    public class Global : System.Web.HttpApplication
    {

        public static No2DB.Base.DRole Role { get; set; }


        public static Dictionary<string, TelegramBotClient> Bots;


        protected void Application_Start(object sender, EventArgs e)
        {
            Role = new No2DB.Base.DRole("TELEGRAM_NOTIFIER");

            ReBindAllBotInfo();

        }



        public static void ReBindAllBotInfo()
        {

            Bots = new Dictionary<string, TelegramBotClient>();

            var bots = Role.GetQ<Models.BotInfo>("BOTS").AllDatasList();

            foreach (var bot in bots)
            {
                if (!string.IsNullOrEmpty(bot.TelegramToken))
                {
                    var pBot = new TelegramBotClient(bot.TelegramToken);
                    pBot.OnMessage += PBot_OnMessage;
                    Bots.Add(bot.Id, pBot);
                }
            }

            foreach (var bot in Bots)
            {

                bot.Value.StartReceiving();

            }
        }

        private static string GetPoolBotByHasCode(int hashCode)
        {

            foreach (var bot in Bots)
            {
                if (bot.Value.GetHashCode() == hashCode)
                {
                    return bot.Key;
                }
            }

            return null;
        }

        private static void PBot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var botClient = sender as TelegramBotClient;

            var botId = GetPoolBotByHasCode(botClient.GetHashCode());
            if (botId != null)
            {

                if (e.Message.Text == "/start")
                {
                    var user = new Models.ChatUserInfo();
                    user.Id = e.Message.Chat.Id + "";
                    user.FirstName = e.Message.Chat.FirstName;
                    user.LastName = e.Message.Chat.LastName;
                    user.LastUpdate = DateTime.Now;
                    Role.GetOp(botId + "_USERS").Update(user.Id, user);
                    user.IsStopNoti = false;
                    Bots[botId].SendTextMessageAsync(user.Id, "歡迎加入此機器人 !!\n您可以輸入 /start 註冊推播\n您可以輸入 /end 取消推播 ");
                }
                else if (e.Message.Text == "/test")
                {

                    var sticker = new InputOnlineFile("https://media.giphy.com/media/zwnsF3HwfAgnu/giphy.gif");
                    Bots[botId].SendStickerAsync(e.Message.Chat.Id, sticker);
                    Bots[botId].SendTextMessageAsync(e.Message.Chat.Id, "歡迎加入此機器人  !!\n您可以輸入 /start 註冊推播\n您可以輸入 /end 取消推播 ");
                }
                else if (e.Message.Text == "/end")
                {

                    // Role.GetOp(botId + "_USERS").Delete(e.Message.Chat.Id + "");

                    var userChat = Role.GetQ<Models.ChatUserInfo>(botId + "_USERS").DataByKey(e.Message.Chat.Id + "");

                    if (userChat != null)
                    {
                        userChat.IsStopNoti = true;
                        userChat.LastUpdate = DateTime.Now;
                        Role.GetOp(botId + "_USERS").Update(e.Message.Chat.Id + "", userChat);
                    }

                    Bots[botId].SendTextMessageAsync(e.Message.Chat.Id, "您已經取消推播，隨時您可以輸入 /start 重新訂閱。");
                }
                else if (e.Message.Text.Contains("/last"))
                {

                    int top = 1;
                    if (!int.TryParse(e.Message.Text.Replace("/last", "").Trim(), out top)) {
                        top = 1;
                    }

                    var ids = Global.Role.GetQ<Models.MessageInfo>(botId + "_MSGS").AllDataKeys;
                    if (ids == null)
                    {
                        Bots[botId].SendTextMessageAsync(e.Message.Chat.Id, "Sorry , 沒有資料 !!");


                    }
                    else
                    {

                        ids = ids.OrderByDescending(x => x).Take(top).ToArray();
                        for (var i = 0; i < ids.Length; i++)
                        {
                            var p = Global.Role.GetQ<Models.MessageInfo>(botId + "_MSGS").DataByKey(ids[i]);


                            if (p.Content.Length <= 2000)
                            {


                                //Bots[botId].SendTextMessageAsync(e.Message.Chat.Id, p.Content + "\n\n" + "--@ " + p.Stamp.ToString("yyyy-MM-dd HH:mm:ss"));
                                Bots[botId].SendTextMessageAsync(e.Message.Chat.Id, p.Content + "\n\n" + "--@ " + p.Stamp.ToString("yyyy-MM-dd HH:mm:ss"), Telegram.Bot.Types.Enums.ParseMode.Default);

                            }
                            else
                            {
                                var content = Global.Split(p.Content, 2000);

                                foreach (var t in content)
                                {
                                    Bots[botId].SendTextMessageAsync(e.Message.Chat.Id, t+ "\n\n" + "--@ " + p.Stamp.ToString("yyyy-MM-dd HH:mm:ss"), Telegram.Bot.Types.Enums.ParseMode.Default);
                                    
                                    System.Threading.Thread.Sleep(1000);
                                }

                            }


                        }
                    }
                }
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        public static string[] Split(string str, int chunkSize)
        {
            int strLength = str.Length;
            int strCount = (strLength + chunkSize - 1) / chunkSize;
            string[] result = new string[strCount];
            for (int i = 0; i < strCount; ++i)
            {
                result[i] = str.Substring(i * chunkSize, Math.Min(chunkSize, strLength));
                strLength -= chunkSize;
            }
            return result;
        }
    }
}