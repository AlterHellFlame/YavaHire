﻿using Microsoft.AspNetCore.SignalR;

namespace YavaPrimum.API.Notify
{
    public class NotifyHub : Hub
    {

        public async Task Send(string message)
        {
            Console.WriteLine(message);
            await this.Clients.All.SendAsync("Receive", message);
        }
    }
}
