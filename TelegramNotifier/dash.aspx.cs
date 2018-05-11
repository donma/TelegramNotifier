using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelegramNotifier
{
    public partial class dash : DPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var bots = Global.Role.GetQ<Models.BotInfo>("BOTS").AllDataKeys;

            ltlBots.Text = (bots!=null)? bots.Length+"":"0";


            var user = 0;
            if (bots != null) {
                foreach (var bot in bots) {

                    user += Global.Role.GetQ<Models.BotInfo>(bot + "_USERS").DataCount();
                }

            }

            ltlUser.Text = user.ToString();


            var msgs = 0;
            if (bots != null)
            {
                foreach (var bot in bots)
                {

                    msgs += Global.Role.GetQ<Models.BotInfo>(bot + "_MSGS").DataCount();
                }

            }
            ltlMessage.Text = msgs.ToString();
        }
    }
}