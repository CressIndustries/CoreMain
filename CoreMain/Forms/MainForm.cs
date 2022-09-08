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
using CoreMain;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

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


            if (Process.GetProcessesByName("Discord").Length > 0)
            {
                RPC.Init(label1, roundedPicture1, label2);
                
                
            } else
            {
                MessageBox.Show("Could not find discord! Make sure it is open!");
            }

            this.Shown += Form_Shown;

            this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);

            var localData = Environment.GetEnvironmentVariable("LocalAppData");
            var filePath = localData + @"\Core\builds.json";
            if (!File.Exists(filePath))
            {
                var ok = File.Create(filePath);
                ok.Close();
            }
            var jsonData = File.ReadAllText(filePath);
                if (jsonData == "")
                {
                    return;

                }

           





            if (!File.Exists(filePath))
            {
                Directory.CreateDirectory(localData + "\\Core");
                var file = File.Create(filePath);

                file.Close();

            }

            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var builds in array)
                {

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 136;
                    pictureBox.Height = 155;
                    pictureBox.Name = builds.Path;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.WaitOnLoad = false;
                    try
                    {
                        pictureBox.ImageLocation = builds.Path + "\\FortniteGame\\Content\\Splash\\Splash.bmp";
                    }
                    catch
                    {
                        pictureBox.Load("https://upload.wikimedia.org/wikipedia/commons/7/7c/Fortnite_F_lettermark_logo.png");
                    }
                    




                                     
                                           



                    pictureBox.Click += this.picClick;
                    flowLayoutPanel1.Controls.Add(pictureBox);


                }





            }




        }
       
        private void picClick(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Fortnite.Launch(pictureBox.Name, label1.Text);

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
            
            var task = Task.Run(async () =>
            {
                for (; ; )
                {
                    await Task.Delay(1000);
                    bool fard32 = label1.Text == "invalid user";

                    if (fard32 == false)
                    {
                        var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
                        if (!regexItem.IsMatch(label1.Text))
                        {
                            MessageBox.Show("You have special Characters in your name! Please Input your discord username with no special characters", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            value = Interaction.InputBox("Please input a valid username!");
                            label1.BeginInvoke((Action)delegate { label1.Text = value; });
                        };
                    }
                }
            });

        }
        public class Build
        {
            public string Name { get; set; }
            public string Path { get; set; }
        }
        private string value;
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = new WebClient().DownloadString("https://pastebin.com/raw/rn5ds6ij");
            siticoneRoundedTextBox1.Text = Properties.Settings.Default.Path;

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
            MessageBox.Show("Sorry This Button is Not used Anymore","Button");
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click_2(object sender, EventArgs e)
        {
        }
    }
}
