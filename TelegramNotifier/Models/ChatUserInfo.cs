using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramNotifier.Models
{
    public class ChatUserInfo
    {
        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public DateTime LastUpdate { get; set; }

        public bool IsStopNoti { get; set; }
    }
}