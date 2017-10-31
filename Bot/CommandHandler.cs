using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Discord.Commands;
using Discord.WebSocket;

namespace Bot
{
    public class CommandHandler
    {
        private CommandService Commands { get; set; }
        private DiscordSocketClient Client { get; set; }

        public async Task Install(DiscordSocketClient Client)
        {
            this.Client = Client;
            Commands = new CommandService();

            await Commands.AddModulesAsync(Assembly.GetCallingAssembly());
            Client.MessageReceived += HandleCommand;
        }
        private async Task HandleCommand(SocketMessage Msg)
        {
            var msg = Msg as SocketUserMessage;
            if (Msg == null) return;

            int argPos = 0;
            if (!(msg.HasStringPrefix(";;", ref argPos) || msg.HasMentionPrefix(Client.CurrentUser, ref argPos))) return;

            if (msg.Content == ";;ping")
            {
                await msg.Channel.SendMessageAsync("Pong!");
            }
        }
    }
}
