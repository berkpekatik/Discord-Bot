using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;


namespace Bot
{
    public partial class Form1 : Form
    {
        private readonly Service _service = new Service();

        public Form1()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _service.Login();
            _service.Client.Log += client_Log;

            while (_service.Client.ConnectionState != ConnectionState.Connected)
            {
                Print(_service.Client.ConnectionState.ToString());
                Thread.Sleep(1000);
            }

            foreach (var guild in _service.Client.Guilds)
            {
                guilds.Items.Add(guild.Name);
            }
            guilds.SelectedIndexChanged += guilds_SelectedIndexChanged;
        }

        private Task client_Log(LogMessage arg)
        {
            Print(arg.Message);
            return null;
        }

        private void Print(string message)
        {
            Invoke((Action)delegate
            {
                cikti.AppendText(message + "\n");
                cikti.ScrollToCaret();
            });
        }

        private void guilds_SelectedIndexChanged(object sender, EventArgs e)
        {
            users.Items.Clear();
            voicec.Items.Clear();
            textc.Items.Clear();
            foreach (var Guild in _service.Client.Guilds)
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

    }
}
