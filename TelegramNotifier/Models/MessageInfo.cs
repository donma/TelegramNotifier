using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramNotifier.Models
{
    public class MessageInfo
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime Stamp { get; set; }
    }
}