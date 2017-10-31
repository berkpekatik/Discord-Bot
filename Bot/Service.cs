using System;
using System.Reflection;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;

namespace Bot
{
    public class Service
    {
        public CommandService Commands;
        public DiscordSocketClient Client;
        private readonly IServiceProvider _serviceProvider;

        public Service()
        {
            Client = new DiscordSocketClient(new DiscordSocketConfig()
            {
                LogLevel = LogSeverity.Verbose
            });
            Commands = new CommandService();

            _serviceProvider = new ServiceCollection()
                .AddSingleton(Client)
                .AddSingleton(Commands)
                .BuildServiceProvider();

            InstallCommands();
        }

        public void Login()
        {
            // Avoid hard coding your token. Use an external source instead in your code.
            string token = "MzcyODQzOTUxOTEwMTU4MzM3.DNY2Pg.uRV5jqZoZf8UhdbArhTyaaolm4w";
            Client.LoginAsync(TokenType.Bot, token).Wait();
            Client.StartAsync().Wait();
        }


        public void InstallCommands()
        {
            // Hook the MessageReceived Event into our Command Handler
            Client.MessageReceived += HandleCommandAsync;
            // Discover all of the commands in this assembly and load them.
            Commands.AddModulesAsync(Assembly.GetEntryAssembly()).Wait();
        }

        private async Task HandleCommandAsync(SocketMessage messageParam)
        {
            // Don't process the command if it was a System Message
            var message = messageParam as SocketUserMessage;
            if (message == null) return;
            // Create a number to track where the prefix ends and the command begins
            int argPos = 0;
            // Determine if the message is a command, based on if it starts with '!' or a mention prefix
            if (!(message.HasCharPrefix('!', ref argPos) || message.HasMentionPrefix(Client.CurrentUser, ref argPos))) return;
            // Create a Command Context
            var context = new SocketCommandContext(Client, message);
            // Execute the command. (result does not indicate a return value, 
            // rather an object stating if the command executed successfully)
            var result = await Commands.ExecuteAsync(context, argPos, _serviceProvider);
            if (!result.IsSuccess)
                await context.Channel.SendMessageAsync(result.ErrorReason);
        }
    }
}
