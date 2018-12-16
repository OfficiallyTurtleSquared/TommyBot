using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Discord.Audio;
using Discord.Net;
using Discord.Rest;
using Discord.Webhook;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Web;

namespace TommyBot.Modules
{
    public class BotMaintenance : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task pingtest()
        {
            var ping = Context.Client.Latency.ToString();
            await Context.Channel.SendMessageAsync($"Pong! Latency == {ping} ms.");
        }
        [Command("gamechange")]
        public async Task gamechanger([Remainder]string game)
        {
            await Context.Client.SetGameAsync(game);
        }
    }
    public class RedArmy : ModuleBase<SocketCommandContext>
    {
        [Command("RAC")]
        public async Task redarmyrng()
        {
            var filelist = @"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir";
            var filegrab = new DirectoryInfo(filelist).GetFiles();
            int index = new Random().Next(0, filegrab.Length);

            await Context.Channel.SendFileAsync($"{filelist}\\{filegrab[index].Name}");
        }
    }
    public class SayCommand : ModuleBase<SocketCommandContext>
    {
        [Command("say")]
        [Alias("sayd")]
        [RequireBotPermission(GuildPermission.ManageMessages)]
        public async Task sayd([Remainder]string message)
        {

            if (Context.Channel is ITextChannel text)
            {
                var oMessageID = Context.Message.Id.ToString();
                var messagesToDelete = await text.GetMessagesAsync(1).FlattenAsync();
                await text.DeleteMessagesAsync(messagesToDelete);
                await Context.Channel.SendMessageAsync($"{message}");
            }
        }
    }
}
