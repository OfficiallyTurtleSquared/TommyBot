using System;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Discord.Audio;
using Discord.Net;
using Discord.Rest;
using Discord.Webhook;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;
using System.Collections.Concurrent;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;

namespace TommyBot
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();
            new CommandHandler();

            await _client.LoginAsync(TokenType.Bot, "NDcwMzkzOTI4MzgyNjc3MDAy.DtesQA.zXxE6jutPc8rfrmgfdwW0EiiYXU");
            await _client.SetStatusAsync(UserStatus.Online);
            await _client.StartAsync();
            _handler = new CommandHandler();
            await _handler.InitializeAsync(_client);
            Console.WriteLine("TommyBot V0.1");
            Console.WriteLine("Ready.");
            Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(2000);
            await _client.SetGameAsync($"Glory to Elon-san!");
            await Task.Delay(-1);

        }

    }
}