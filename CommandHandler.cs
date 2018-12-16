﻿using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Reflection;
using System.Threading.Tasks;
using Discord.Rest;
using Discord;
using System.Diagnostics;


namespace TommyBot
{
    public class CommandHandler
    {
        private DiscordSocketClient _client;

        private CommandService _service;


        public async Task InitializeAsync(DiscordSocketClient client)
        {
            _client = client;

            _service = new CommandService();

            await _service.AddModulesAsync(Assembly.GetEntryAssembly());

            _client.MessageReceived += HandleCommandAsync;
        }

        private async Task HandleCommandAsync(SocketMessage s)
        {
            var msg = s as SocketUserMessage;
            if (msg == null) return;

            var context = new SocketCommandContext(_client, msg);

            int argPos = 0;
            if (msg.HasCharPrefix('?', ref argPos) && msg.Author.IsBot == false)
            {
                var result = await _service.ExecuteAsync(context, argPos);

                if (!result.IsSuccess && result.Error != CommandError.UnknownCommand)
                {

                }
            }
        }
    }
}