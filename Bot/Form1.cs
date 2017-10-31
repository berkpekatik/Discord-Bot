using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.WebSocket;


namespace Bot
{
    public partial class Form1 : Form
    {
        DiscordSocketClient client;
        CommandHandler handler;
        public Form1()
        {
            
            InitializeComponent();
            
    }
        
        private async void button1_Click(object sender, EventArgs e)
        {
            handler = new CommandHandler();
            string Token = "MzcyODQzOTUxOTEwMTU4MzM3.DNY2Pg.uRV5jqZoZf8UhdbArhTyaaolm4w";
            client = new DiscordSocketClient(new DiscordSocketConfig()
            {
                LogLevel = LogSeverity.Verbose
            });

            await handler.Install(client);

            client.Log += client_Log;
            try
            {
                await client.LoginAsync(TokenType.Bot, Token);
                await client.StartAsync();
            }
            catch 
            {

                MessageBox.Show("ERROR");
                return;
            }
            await Task.Delay(3000);
            foreach (var Guild in client.Guilds)
            {
                guilds.Items.Add(Guild.Name);
            }
            guilds.SelectedIndexChanged += guilds_SelectedIndexChanged;
        }

        private Task client_Log(LogMessage arg)
        {
            Invoke((Action)delegate {
                cikti.AppendText(arg + "\n");
            }); 
            return null;
        }

        private void guilds_SelectedIndexChanged(object sender, EventArgs e)
        {
            users.Items.Clear();
            voicec.Items.Clear();
            textc.Items.Clear();
            foreach (var Guild in client.Guilds)
            {
                if (Guild.Name == guilds.Text)
                {
                    foreach (var vc in Guild.VoiceChannels)
                    {
                        voicec.Items.Add(vc.Name);
                    }
                    foreach (var tc in Guild.TextChannels)
                    {
                        textc.Items.Add(tc.Name);
                    }
                    foreach (var user in Guild.Users)
                    {
                        users.Items.Add(user.Username);
                    }
                }
            }
        }

        private void cikti_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
