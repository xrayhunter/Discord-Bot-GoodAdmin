﻿using GoodAdmin_API;
using System;
using System.Threading.Tasks;

namespace Module_Test
{
    public class Module : APIModule
    {
        // Sync
        public Task Load(Discord.WebSocket.DiscordSocketClient client)
        {
            return Task.CompletedTask;
        }
    }
}
