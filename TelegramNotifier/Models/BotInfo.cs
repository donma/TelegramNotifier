using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramNotifier.Models
{
    public class BotInfo
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public string BroadcastToken { get; set; }
        public string TelegramToken { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}