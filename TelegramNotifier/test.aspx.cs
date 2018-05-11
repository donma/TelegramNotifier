using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelegramNotifier
{
    public partial class test : DPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlS.Text = "";
            if (!IsPostBack)
            {

                var bots = Global.Role.GetQ<Models.BotInfo>("BOTS").AllDatasList();

                bots = bots.OrderByDescending(x => x.LastUpdate).ToList();

                foreach (var bot in bots)
                {
                    ddlBots.Items.Add(new ListItem(bot.Title, bot.Id));
                }
            }

        }

        protected void btnReceiveData_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string targetAddress ="http://"+ Request.Url.Authority + "/api/push.aspx";
          //  string parameters ="id="+ddlBots.SelectedValue+"&token="+txtBCToken.Text+"&content="+Server.UrlPathEncode(txtContent.Text);
            wc.Encoding = Encoding.UTF8;
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

            NameValueCollection nc = new NameValueCollection();
            nc["token"] = txtBCToken.Text;
            nc["content"] = Server.HtmlEncode(txtContent.Text);
            nc["id"] = ddlBots.SelectedValue;
            byte[] bResult = wc.UploadValues(targetAddress, nc);

            string result = Encoding.UTF8.GetString(bResult);

            if (result.Contains("error")) {
                ltlS.Text = "<script>toastr.error('"+ result + "');</script>";

            }
        }
    }
}