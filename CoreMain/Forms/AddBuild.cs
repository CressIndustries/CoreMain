using CoreMain.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CoreMain.Forms
{
    public partial class AddBuild : Form
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
        public AddBuild()
        {
            InitializeComponent();
        }
        private string fortniteGame;
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddBuild_Load(object sender, EventArgs e)
        {
            
            var localData = Environment.GetEnvironmentVariable("LocalAppData");
            var filePath = localData + @"\Core\builds.json";

            
           
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public string GetBuildName
        {
            get { return fortniteGame; }
            set { fortniteGame = value; }
        }
        public string GetBuildVersion
        {
            get { return siticoneTextBox1.Text; }
            set { siticoneTextBox1.Text = value; }
        }
        public class Build
        {
            public string Name { get; set; }
            public string Path { get; set; }
        }
        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            using (var dummy = new AddBuild())
            {
                dialog.IsFolderPicker = true;


                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {

                    fortniteGame = dialog.FileName + @"\FortniteGame";
                    if (!Directory.Exists(fortniteGame))
                    {
                        MessageBox.Show("Specified Path does not have FortniteGame in it! Make sure the folder has FortniteGame AND Engine");




                    }
                    else
                    {
                        if (siticoneTextBox1.Text == "Build Name")
                        {
                            MessageBox.Show("Name is empty!");
                            return;
                        }
                        PathText.Text = dialog.FileName;
                        this.BringToFront();

                        
                    }


                }
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PathText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var localData = Environment.GetEnvironmentVariable("LocalAppData");
            var filePath = localData + @"\Core\builds.json";
            var jsonData = File.ReadAllText(filePath);

            PictureBox pictureBox = new PictureBox();
            pictureBox.LoadAsync(PathText.Text + "\\FortniteGame\\Content\\Splash\\Splash.bmp");

            var _build = JsonConvert.DeserializeObject<List<Build>>(jsonData) ?? new List<Build>();

            _build.Add(new Build { Name = siticoneTextBox1.Text, Path = PathText.Text });
            jsonData = JsonConvert.SerializeObject(_build, Formatting.Indented);

            File.WriteAllText(filePath, jsonData);

            MessageBox.Show("Added Build!");

            Application.Restart();
        }

        private void siticoneButton2_Click_1(object sender, EventArgs e)
        {
            var localData = Environment.GetEnvironmentVariable("LocalAppData");
            var filePath = localData + @"\Core\builds.json";
            var jsonData = File.ReadAllText(filePath);

            PictureBox pictureBox = new PictureBox();
            pictureBox.LoadAsync(PathText.Text + "\\FortniteGame\\Content\\Splash\\Splash.bmp");

            var _build = JsonConvert.DeserializeObject<List<Build>>(jsonData) ?? new List<Build>();

            _build.Add(new Build { Name = siticoneTextBox1.Text, Path = PathText.Text });
            jsonData = JsonConvert.SerializeObject(_build, Formatting.Indented);

            File.WriteAllText(filePath, jsonData);

            MessageBox.Show("Added Build!");

            Application.Restart();
        }
    }
}
