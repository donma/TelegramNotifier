using System;
using System.Threading;
using Telegram.Bot;

namespace TelegramNotifier
{
    public partial class bot : DPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlS.Text = "";

            if (!string.IsNullOrEmpty(Request["id"]) && !IsPostBack)
            {
                var botInfo = Global.Role.GetQ<Models.BotInfo>("BOTS").DataByKey(Request["id"]);

                if (botInfo != null)
                {
                    txtBCToken.Text = botInfo.BroadcastToken;
                    txtTGToken.Text = botInfo.TelegramToken;
                    ltlId.Text = botInfo.Id;
                    txtTitle.Text = botInfo.Title;
                }
            }
        }

        protected  void  btnReceiveData_Click(object sender, EventArgs e)
        {

            var bot = new Models.BotInfo();

            if (string.IsNullOrEmpty(Request["id"]))
            {
                bot.Id = No2DB.Util.GuidShort();
            }
            else
            {
                bot.Id = Request["id"];
            }

            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                ltlS.Text = "<script>toastr.warning('Title cant be null.');</script>";
            }

            bot.Title = txtTitle.Text;
            bot.BroadcastToken = txtBCToken.Text;
            bot.TelegramToken = txtTGToken.Text;
            bot.LastUpdate = DateTime.Now;

            Global.Role.GetOp("BOTS").Update(bot.Id, bot);


            Thread t = new Thread(new ThreadStart(Global.ReBindAllBotInfo));
            t.Start();


            ltlS.Text = "<script>toastr.success('Success Update.');toastr.info('因為儲存資訊，會造成暫時中斷進行中的廣播.');</script>";
          
        }

       
    }
}