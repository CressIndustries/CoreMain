using CoreMain.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;
using System.Net;

namespace CoreMain
{
    public partial class MainForm : Form
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
        public MainForm()
        {
            InitializeComponent();

            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            if (Process.GetProcessesByName("Discord").Length > 0)
            {
                RPC.Init(label1, roundedPicture1, label2);
            }

            this.Shown += Form_Shown;

            this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Lawin.Stop();
            }
            catch
            {

            }



        }
        private static bool IsWindows10OrGreater(int build = -1)
        {
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
        }
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form_Shown(Object sender, EventArgs e)
        {


        }
        public class Build
        {
            public string Name { get; set; }
            public string Path { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            siticoneRoundedTextBox1.Text = Properties.Settings.Default.Path;
            pictureBox2.LoadAsync($"{siticoneRoundedTextBox1.Text}\\FortniteGame\\Content\\Splash\\Splash.bmp");
            Lawin.Start();
        }
        private void roundedPicture1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddBuild1_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.IsFolderPicker = true;
                dialog.Multiselect = false;
                dialog.Title = "Please Select your FortniteGame Folder!";
                dialog.EnsureFileExists = false;
                dialog.EnsurePathExists = true;

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    var fortniteGame = dialog.FileName + "\\FortniteGame";
                    if (!Directory.Exists(fortniteGame))
                    {
                        MessageBox.Show("This Folder Does not Have FortniteGame inside of it! Make sure it does!");
                    }
                    else
                    {
                        siticoneRoundedTextBox1.Text = dialog.FileName;
                        Properties.Settings.Default.Path = dialog.FileName;
                        Properties.Settings.Default.Save();
                        pictureBox2.LoadAsync($"{siticoneRoundedTextBox1.Text}\\FortniteGame\\Content\\Splash\\Splash.bmp");
                    }

                }
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                MessageBox.Show("Empty Username!");
            }
            else
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://cdn.discordapp.com/attachments/998358440080572476/1012904331718164601/pakchunkPleasantFix-WindowsClient.pak", $"{siticoneRoundedTextBox1.Text}\\FortniteGame\\Content\\Paks\\pakchunkPleasantFix-WindowsClient.pak");
                    client.DownloadFile("https://cdn.discordapp.com/attachments/998358440080572476/1012904331386830939/pakchunkPleasantFix-WindowsClient.sig", $"{siticoneRoundedTextBox1.Text}\\FortniteGame\\Content\\Paks\\pakchunkPleasantFix-WindowsClient.sig");
                    client.DownloadFile("https://cdn.discordapp.com/attachments/1000926828514529290/1015424941371433000/pakchunkTectorGriddy-WindowsClient_3.pak", $"{siticoneRoundedTextBox1.Text}\\FortniteGame\\Content\\Paks\\pakchunkTectorGriddy-WindowsClient_3.pak");
                    client.DownloadFile("https://cdn.discordapp.com/attachments/1000926828514529290/1015424941165920276/pakchunkTectorGriddy-WindowsClient_3.sig", $"{siticoneRoundedTextBox1.Text}\\FortniteGame\\Content\\Paks\\pakchunkTectorGriddy-WindowsClient_3.sig");
                    client.DownloadFile("https://cdn.discordapp.com/attachments/1000926828514529290/1012222418254843966/pakchunkTI93V5-WindowsClient.pak", $"{siticoneRoundedTextBox1.Text}\\FortniteGame\\Content\\Paks\\pakchunkTI93V5-WindowsClient.pak");
                    client.DownloadFile("https://cdn.discordapp.com/attachments/1000926828514529290/1012222418577784912/pakchunkTI93V5-WindowsClient.sig", $"{siticoneRoundedTextBox1.Text}\\FortniteGame\\Content\\Paks\\pakchunkTI93V5-WindowsClient.sig");
                    client.DownloadFile("https://cdn.discordapp.com/attachments/1000926828514529290/1015445231983923280/pakchunkGliderFix-WindowsClient.pak", $"{siticoneRoundedTextBox1.Text}\\FortniteGame\\Content\\Paks\\pakchunkGliderFix-WindowsClient.pak");
                    client.DownloadFile("https://cdn.discordapp.com/attachments/1000926828514529290/1015445232302702644/pakchunkGliderFix-WindowsClient.sig", $"{siticoneRoundedTextBox1.Text}\\FortniteGame\\Content\\Paks\\pakchunkGliderFix-WindowsClient.sig");
                }
                Properties.Settings.Default.Username = label1.Text;
                Properties.Settings.Default.Save();
                Fortnite.Launch(siticoneRoundedTextBox1.Text, label1.Text);

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddBuild_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This does not work but you can see the page.");
            AddBuild form = new AddBuild();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void corButton1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            ModsNeeded form = new ModsNeeded();
            form.Show();
        }

        private void siticoneButton2_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                MessageBox.Show("Empty Username!");
            }
            else
            {
                Properties.Settings.Default.Username = label1.Text;
                Properties.Settings.Default.Save();
                Fortnite.Launch(siticoneRoundedTextBox1.Text, label1.Text);

            }
        }
    }
}
