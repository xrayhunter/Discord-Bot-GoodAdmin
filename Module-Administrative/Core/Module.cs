﻿using GoodAdmin_API;
using GoodAdmin_API.Core;
using System;
using System.Threading.Tasks;

namespace Module_Administrative
{
    public class Module : APIModule
    {
        // Sync
        public Task Load(Discord.WebSocket.DiscordSocketClient client)
        {
            new Configuration();

            return Task.CompletedTask;
        }
    }
}
