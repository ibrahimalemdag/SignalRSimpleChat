using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SsignalRChatApp
{
    public class NodeHub : Hub<ITypedHubClient>
    {
        public void Send(string name, string message)
        {
            Clients.All.NotifyMessageToClients(name, message);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendMessage(user, message);
        }
    }
    
}
