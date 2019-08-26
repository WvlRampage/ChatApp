using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatAppV0._1
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.SendChat(name, message);
        }
    }
}