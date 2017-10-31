using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.WebSocket;


namespace Bot.Modules.Public
{
    public class Test : ModuleBase
    {

        [Command("pong", RunMode = RunMode.Async)]
        public async Task SendPong()
        {

            await Context.Channel.SendMessageAsync($"{Context.User.Mention} sadasd");
        }
    }
}
