using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreMain.Forms
{
    public partial class ModsNeeded : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public ModsNeeded()
        {
            InitializeComponent();

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ModsNeeded_Load(object sender, EventArgs e)
        {
            label3.Text = new WebClient().DownloadString("https://pastebin.com/raw/rn5ds6ij");
            label4.Text = Properties.Settings.Default.Path;
        }

        private void corButton1_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/1000926828514529290/1012222418254843966/pakchunkTI93V5-WindowsClient.pak", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkTI93V5-WindowsClient.pak");
                client.DownloadFile("https://cdn.discordapp.com/attachments/1000926828514529290/1012222418577784912/pakchunkTI93V5-WindowsClient.sig", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkTI93V5-WindowsClient.sig");    
            }
        }

        private void corButton3_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/998358440080572476/1012904331718164601/pakchunkPleasantFix-WindowsClient.pak", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkPleasantFix-WindowsClient.pak");
                client.DownloadFile("https://cdn.discordapp.com/attachments/998358440080572476/1012904331386830939/pakchunkPleasantFix-WindowsClient.sig", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkPleasantFix-WindowsClient.sig");
            }
        }

        private void corButton2_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/1000926828514529290/1015445231983923280/pakchunkGliderFix-WindowsClient.pak", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkGliderFix-WindowsClient.pak");
                client.DownloadFile("https://cdn.discordapp.com/attachments/1000926828514529290/1015445232302702644/pakchunkGliderFix-WindowsClient.sig", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkGliderFix-WindowsClient.sig");
            }
        }

        private void corButton4_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/1016450725179576351/1016453458380984390/pakchunkShottaFlow3-WindowsClient.pak", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkShottaFlow3-WindowsClient.pak");
                client.DownloadFile("https://cdn.discordapp.com/attachments/1016450725179576351/1016454120032456804/pakchunkShottaFlow3-WindowsClient.sig", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkShottaFlow3-WindowsClient.sig");
            }
        }

        private void corButton5_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/997023464089206815/1016365084479602778/pakchunkRenegadePick-WindowsClient.pak", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkRenegadePick-WindowsClient.pak");
                client.DownloadFile("https://cdn.discordapp.com/attachments/997023464089206815/1016365084697710612/pakchunkRenegadePick-WindowsClient.sig", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkRenegadePick-WindowsClient.sig");
            }
        }

        private void corButton6_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/1000926828514529290/1015424941371433000/pakchunkTectorGriddy-WindowsClient_3.pak", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkTectorGriddy-WindowsClient_3.pak");
                client.DownloadFile("https://cdn.discordapp.com/attachments/1000926828514529290/1015424941165920276/pakchunkTectorGriddy-WindowsClient_3.sig", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkTectorGriddy-WindowsClient_3.sig");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void corButton8_Click(object sender, EventArgs e)
        {
            String myPath1 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkTI93V5-WindowsClient.pak";
            File.Delete(myPath1);
            String myPath2 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkTI93V5-WindowsClient.sig";
            File.Delete(myPath2);
        }

        private void corButton10_Click(object sender, EventArgs e)
        {
            String myPath2 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkPleasantFix-WindowsClient.pak";
            File.Delete(myPath2);
            String myPath3 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkPleasantFix-WindowsClient.sig";
            File.Delete(myPath3);
        }

        private void corButton9_Click(object sender, EventArgs e)
        {
            String myPath1 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkTectorGriddy-WindowsClient_3.pak";
            File.Delete(myPath1);
            String myPath2 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkTectorGriddy-WindowsClient_3.sig";
            File.Delete(myPath2);
        }

        private void corButton7_Click(object sender, EventArgs e)
        {
            String myPath1 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkRenegadePick-WindowsClient.pak";
            File.Delete(myPath1);
            String myPath2 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkRenegadePick-WindowsClient.sig";
            File.Delete(myPath2);
        }

        private void corButton12_Click(object sender, EventArgs e)
        {
            String myPath1 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkTectorGriddy-WindowsClient_3.pak";
            File.Delete(myPath1);
            String myPath2 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkTectorGriddy-WindowsClient_3.sig";
            File.Delete(myPath2);
        }

        private void corButton11_Click(object sender, EventArgs e)
        {
            String myPath1 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkShottaFlow3-WindowsClient.pak";
            File.Delete(myPath1);
            String myPath2 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkShottaFlow3-WindowsClient.sig";
            File.Delete(myPath2);
        }

        private void corButton14_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/1011300929749921874/1016368660853575731/pakchunkScytheSoundON-WindowsClient.pak", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkScytheSoundON-WindowsClient.pa");
                client.DownloadFile("https://cdn.discordapp.com/attachments/1011300929749921874/1016368661096837163/pakchunkScytheSoundON-WindowsClient.sig", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkScytheSoundON-WindowsClient.sig");
            }
        }

        private void corButton13_Click(object sender, EventArgs e)
        {
            String myPath1 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkScytheSoundON-WindowsClient.pak";
            File.Delete(myPath1);
            String myPath2 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkScytheSoundON-WindowsClient.sig";
            File.Delete(myPath2);
        }

        private void corButton16_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/1016450725179576351/1016453476563288154/pakchunkPinkSparkle-WindowsClient.pak", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkPinkSparkle-WindowsClient.pak");
                client.DownloadFile("https://cdn.discordapp.com/attachments/1016450725179576351/1016454206401552384/pakchunkPinkSparkle-WindowsClient.sig", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkPinkSparkle-WindowsClient.sig");
            }
        }

        private void corButton15_Click(object sender, EventArgs e)
        {
            String myPath1 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkPinkSparkle-WindowsClient.pak";
            File.Delete(myPath1);
            String myPath2 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkPinkSparkle-WindowsClient.sig";
            File.Delete(myPath2);
        }

        private void corButton18_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/1016450725179576351/1016467386687299664/pakchunkBOB-WindowsClient.pak", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkBOB-WindowsClient.pak");
                client.DownloadFile("https://cdn.discordapp.com/attachments/1016450725179576351/1016467386473386094/pakchunkBOB-WindowsClient.sig", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkBOB-WindowsClient.sig");
            }
        }

        private void corButton17_Click(object sender, EventArgs e)
        {
            String myPath1 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkBOB-WindowsClient.pak";
            File.Delete(myPath1);
            String myPath2 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkBOB-WindowsClient.sig";
            File.Delete(myPath2);
        }

        private void corButton20_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/1016450725179576351/1017485436815421523/pakchunkStarWand-WindowsClient.pak", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkStarWand-WindowsClient.pak");
                client.DownloadFile("https://cdn.discordapp.com/attachments/1016450725179576351/1017485437012549703/pakchunkStarWand-WindowsClient.sig", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkStarWand-WindowsClient.sig");
            }
        }

        private void corButton19_Click(object sender, EventArgs e)
        {
            String myPath1 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkStarWand-WindowsClient.pak";
            File.Delete(myPath1);
            String myPath2 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkStarWand-WindowsClient.sig";
            File.Delete(myPath2);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void corButton22_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/997023464089206815/1017494837441867806/pakchunkCandyAxe-WindowsClient.pak", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkCandyAxe-WindowsClient.pak");
                client.DownloadFile("https://cdn.discordapp.com/attachments/997023464089206815/1017494837647384636/pakchunkCandyAxe-WindowsClient.sig", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkCandyAxe-WindowsClient.sig");
            }
        }

        private void corButton21_Click(object sender, EventArgs e)
        {
            String myPath1 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkCandyAxe-WindowsClient.pak";
            File.Delete(myPath1);
            String myPath2 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkCandyAxe-WindowsClient.sig";
            File.Delete(myPath2);
        }

        private void corButton24_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/1000567894314319903/1017501777333080074/pakchunkElegantShovel-WindowsClient.pak", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkElegantShovel-WindowsClient.pak");
                client.DownloadFile("https://cdn.discordapp.com/attachments/1000567894314319903/1017501777567948810/pakchunkElegantShovel-WindowsClient.sig", $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkElegantShovel-WindowsClient.sig");
            }
        }

        private void corButton23_Click(object sender, EventArgs e)
        {
            String myPath1 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkElegantShovel-WindowsClient.pak";
            File.Delete(myPath1);
            String myPath2 = $"{label4.Text}\\FortniteGame\\Content\\Paks\\pakchunkElegantShovel-WindowsClient.sig";
            File.Delete(myPath2);
        }
    }
}
