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


            /* Random rnd = new Random();
            int song = rnd.Next(1, 27);

            if (song == 1) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Budenny's March.mp3");
            if (song == 2) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Does the Russian Want the War.mp3");
            if (song == 3) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\In the Forest, Near the Frontline.mp3");
            if (song == 4) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Katiusha.mp3");
            if (song == 5) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\March of the defenders of Moscow.mp3");
            if (song == 6) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Moscow Defender's Song.mp3");
            if (song == 7) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\My Moscow.mp3");
            if (song == 8) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\National Anthem of USSR.mp3");
            if (song == 9) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Our Power.mp3");
            if (song == 10) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Red Army Choir - The song about the 27th division.mp3");
            if (song == 11) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Red Army Choir - Victory Day.mp3");
            if (song == 12) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Red Army Choir - We Are The Red Cavalry.mp3");
            if (song == 13) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Red Army Choir - When The Soldiers Sing.mp3");
            if (song == 14) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Red Army Choir Cossack's Song..mp3");
            if (song == 15) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Red Army Choir Oh Fields, My fields..mp3");
            if (song == 16) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Red Army Choir On the Road..mp3");
            if (song == 17) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Red Army Choir Partisan's Song..mp3");
            if (song == 18) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Red Army Choir The Red Army Is the Strongest..mp3");
            if (song == 19) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Spring of 1945.mp3");
            if (song == 20) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\The Horse Army Song.mp3");
            if (song == 21) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\The Parade's Song.mp3");
            if (song == 22) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\The Party's Song.mp3");
            if (song == 23) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\The Red Army Choir Sacred War..mp3");
            if (song == 24) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\The Russian Walk.mp3");
            if (song == 25) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Toula's Defenders Song.mp3");
            if (song == 26) await Context.Channel.SendFileAsync(@"C:\Users\TurtleSquared\Documents\Visual Studio 2017\Projects\OperationRussianElon\OperationRussianElon\RedChoir\Varshavianka.mp3");
            if (song == 27) await Context.Channel.SendFileAsync(@"");*/
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