using System;
using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using System.Drawing;

namespace CressOptions
{
    class Program
    {

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {


            Console.ForegroundColor = ConsoleColor.Green;

            Console.Title = "Project Core Updater (Beta)";

            string dir = @"C:\CressMods";
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            Console.WriteLine();
            Console.Write("       ██████╗░██████╗░░█████╗░░░░░░██╗███████╗░█████╗░████████╗  ░█████╗░░█████╗░██████╗░███████╗\n", ConsoleColor.Green);
            Console.Write("       ██╔══██╗██╔══██╗██╔══██╗░░░░░██║██╔════╝██╔══██╗╚══██╔══╝  ██╔══██╗██╔══██╗██╔══██╗██╔════╝\n", ConsoleColor.Green);
            Console.Write("       ██████╔╝██████╔╝██║░░██║░░░░░██║█████╗░░██║░░╚═╝░░░██║░░░  ██║░░╚═╝██║░░██║██████╔╝█████╗░░\n", ConsoleColor.Green);
            Console.Write("       ██╔═══╝░██╔══██╗██║░░██║██╗░░██║██╔══╝░░██║░░██╗░░░██║░░░  ██║░░██╗██║░░██║██╔══██╗██╔══╝░░\n", ConsoleColor.Green);
            Console.Write("       ██║░░░░░██║░░██║╚█████╔╝╚█████╔╝███████╗╚█████╔╝░░░██║░░░  ╚█████╔╝╚█████╔╝██║░░██║███████╗\n", ConsoleColor.Green);
            Console.Write("       ╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚════╝░╚══════╝░╚════╝░░░░╚═╝░░░  ░╚════╝░░╚════╝░╚═╝░░╚═╝╚══════╝\n", ConsoleColor.Green);
            Console.Write("                                                                                                   \n", ConsoleColor.Green);
            Console.Write("\n\n\n");


            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            {

                System.Threading.Thread.Sleep(5000);
                File.Delete(@"CoreMain,exe");
                client.DownloadFile("https://coresexpenis.000webhostapp.com/CoreMain.zip", @"CoreMain.zip");
                string zipPath = @"CoreMain.zip";
                string extractPath = @"CoreMain.zip";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@"CoreMain.zip");
                Process.Start(@"CoreMain.exe");
                Thread.Sleep(6000);
                Environment.Exit(0);
            }
            catch
            {
                Process.Start(@"CoreMain.exe");
                Thread.Sleep(6000);
                Environment.Exit(0);

            }

            switch (Console.ReadLine())
            {
                case "1":
                    return true;
                case "2":
                    return true;
                case "3":
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }
    }
}