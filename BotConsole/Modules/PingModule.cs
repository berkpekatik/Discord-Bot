using System.Threading.Tasks;
using Discord.Commands;

namespace BotConsole.Modules
{

    public class PingModule : ModuleBase<SocketCommandContext>
    {
        // ~say hello -> hello
        [Command("ping")]
        [Summary("pong")]
        public async Task SayAsync()
        {
            // ReplyAsync is a method on ModuleBase
            await ReplyAsync("pong");
        }
    }
}
