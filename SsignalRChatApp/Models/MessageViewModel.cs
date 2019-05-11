using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SsignalRChatApp
{
    public class MessageViewModel
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public MessengerNodeViewModel SourceNode { get; set; }
        public MessengerNodeViewModel TargetNode { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}