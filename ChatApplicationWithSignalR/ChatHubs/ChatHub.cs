﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatApplicationWithSignalR.ChatHubs
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
            //Clients.All.addNewMessage(UriHostNameType, )
        }

        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}