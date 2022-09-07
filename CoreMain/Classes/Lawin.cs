using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CoreMain
{
    internal class Lawin
    {
        public static Process process = new Process();
        public static void Start()
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\LawinServer-main"))
            {
                MessageBox.Show("LawinServer not found! Make sure that lawinserver is inside Core launcher folder and it is named LawinServer-main");
            }
            else
            {
                try
                {
                    string currentDir = Directory.GetCurrentDirectory();
                    Directory.SetCurrentDirectory(currentDir + "\\LawinServer-main");

                    process.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\start.bat";
                    process.StartInfo.UseShellExecute = false;
                    process.Start();
                    Directory.SetCurrentDirectory(currentDir);
                }
                catch
                {
                    MessageBox.Show("Could Not Start LawinServer!");
                }

            }


        }
        public static void Stop()
        {
            process.Kill();
        }
    }
}