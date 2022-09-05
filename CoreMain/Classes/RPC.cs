using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;

namespace CoreMain
{
    internal class RPC
    {

        public static DiscordRpcClient client;

        public static void Init(Label l, PictureBox pic, Label lab)
        {

            client = new DiscordRpcClient("873361408706879579", autoEvents: true);

            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.OnReady += (sender, e) =>
            {

                l.BeginInvoke((Action)delegate { l.Text = e.User.Username; });
                lab.BeginInvoke((Action)delegate { lab.Text = "Logged in as " + e.User.Username; });

                _ = pic.BeginInvoke((Action)delegate { pic.Load(e.User.GetAvatarURL(User.AvatarFormat.GIF)); });

            };
            client.OnError += (object sender, ErrorMessage e) =>
            {
                MessageBox.Show("Please open discord for this to work!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SystemSounds.Exclamation.Play();
                Application.Exit();
            };
            client.OnConnectionFailed += (sender, e) =>
            {
                MessageBox.Show("Please open discord for this to work!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SystemSounds.Exclamation.Play();

                Application.Exit();
            };


            client.Initialize();




            client.SetPresence(new RichPresence()
            {
                Details = "Idle",
                State = "",
                Assets = new Assets()
                {
                    LargeImageKey = "arilauncher",
                    LargeImageText = "Sex"
                }
            });

        }
        public static void Close()
        {
            client.Dispose();
        }
    }
}