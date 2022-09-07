using System;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;

namespace CoreMain
{
    public static class Fortnite
    {
        public static string args;
        public static void Launch(string path, string username)
        {
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Could not find Fortnite!");
                return;
            }
            bool sex = username.Contains(" ");

            if (sex)
            {
                var joined = username.Replace(" ", "_");
                args = $"-epicapp=Fortnite -epicenv=Prod -epicportal -AUTH_TYPE=epic -AUTH_LOGIN=" + joined + " -AUTH_PASSWORD=unused -epiclocale=en-us -skippatchcheck -fltoken=6969";
            }
            else
            {
                args = $"-epicapp=Fortnite -epicenv=Prod -epicportal -AUTH_TYPE=epic -AUTH_LOGIN=" + username + " -AUTH_PASSWORD=unused -epiclocale=en-us -skippatchcheck -fltoken=6969";
            }
            string shipping = "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping.exe";

            Process FN = new Process();
            string fullpath = path + shipping;
            FN.StartInfo.Arguments = args;
            FN.StartInfo.FileName = fullpath;
            FN.StartInfo.UseShellExecute = false;
            FN.StartInfo.RedirectStandardOutput = true;
            bool flag2 = !File.Exists(Directory.GetCurrentDirectory() + "\\FortniteClient-Win64-Shipping_BE.exe");
            if (flag2)
            {
                DownloadFile("https://cdn.discordapp.com/attachments/958139296936783892/1000707724507623424/FortniteClient-Win64-Shipping_BE.exe", Directory.GetCurrentDirectory() + "\\FortniteClient-Win64-Shipping_BE.exe");
            }
            bool flag3 = !File.Exists(Directory.GetCurrentDirectory() + "\\FortniteLauncher.exe");
            if (flag3)
            {
                DownloadFile("https://cdn.discordapp.com/attachments/958139296936783892/1000707724818006046/FortniteLauncher.exe", Directory.GetCurrentDirectory() + "\\FortniteLauncher.exe");
            }
            Process.Start(new ProcessStartInfo
            {
                FileName = Directory.GetCurrentDirectory() + "\\FortniteLauncher.exe",
                CreateNoWindow = true,
                UseShellExecute = false
            });
            Process.Start(new ProcessStartInfo
            {
                FileName = Directory.GetCurrentDirectory() + "\\FortniteClient-Win64-Shipping_BE.exe",
                CreateNoWindow = true,
                UseShellExecute = false
            });

            FN.Start();




            int id = FN.Id;
            string Backend = Directory.GetCurrentDirectory() + "\\Fortnite.dll";




            Inject(id, Backend);
            for (; ; )
            {
                string Output = FN.StandardOutput.ReadLine();
                bool init = Output.Contains("Game Engine Initialized");
                if (init)
                {
                    string console = Directory.GetCurrentDirectory() + "\\Api.dll";
                    string MemoryLeak = Directory.GetCurrentDirectory() + "\\Leaker.dll";
                    Thread.Sleep(3000);
                    Inject(id, MemoryLeak);
                    Inject(id, console);
                    Environment.Exit(0);
                }
            }


        }
        public static void DownloadFile(string Url, string Path)
        {
            new WebClient().DownloadFile(Url, Path);
        }
        public static void Inject(int procId, string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("DLL Not Found! Please make sure Both Api.dll, Fortnite.dll and Leaker.dll exists inside the folder!");
                return;
            }
            IntPtr hProcess = OpenProcess(1082, false, procId);
            IntPtr procAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
            uint num = (uint)((path.Length + 1) * Marshal.SizeOf(typeof(char)));
            IntPtr intPtr = VirtualAllocEx(hProcess, IntPtr.Zero, num, 12288U, 4U);
            UIntPtr uintPtr;
            WriteProcessMemory(hProcess, intPtr, Encoding.Default.GetBytes(path), num, out uintPtr);
            CreateRemoteThread(hProcess, IntPtr.Zero, 0U, procAddress, intPtr, 0U, IntPtr.Zero);
        }

        // Thank you to Jurji15 for this part.
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle, int dwThreadId);

        [DllImport("kernel32.dll")]
        public static extern int SuspendThread(IntPtr hThread);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("kernel32.dll")]
        public static extern int ResumeThread(IntPtr hThread);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleCtrlHandler(HandlerRoutine HandlerRoutine, bool Add);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);


        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);


        public const int PROCESS_CREATE_THREAD = 2;


        public const int PROCESS_VM_OPERATION = 8;


        public const int PROCESS_VM_WRITE = 32;


        public const int PROCESS_VM_READ = 16;


        public const int PROCESS_QUERY_INFORMATION = 1024;


        public const uint PAGE_READWRITE = 4U;


        public const uint MEM_COMMIT = 4096U;


        public const uint MEM_RESERVE = 8192U;


        public delegate bool HandlerRoutine(int dwCtrlType);
        public partial class AsyncStreamReader
        {
            public event EventHandler<string> DataReceived;

            public bool Active { get; private set; }

            public AsyncStreamReader(StreamReader reader)
            {
                _reader = reader;
                Active = false;
            }

            public void Start()
            {
                if (!Active)
                {
                    Active = true;
                    BeginReadAsync();
                }
            }

            public void Stop()
            {
                Active = false;
            }

            protected void BeginReadAsync()
            {
                if (Active) _reader.BaseStream.BeginRead(_buffer, 0, _buffer.Length, new AsyncCallback(ReadCallback), null);
            }

            private void ReadCallback(IAsyncResult asyncResult)
            {
                if (_reader == null) return;

                int num = _reader.BaseStream.EndRead(asyncResult);
                string data = null;

                if (num > 0)
                    data = _reader.CurrentEncoding.GetString(_buffer, 0, num);
                else
                    Active = false;

                DataReceived?.Invoke(this, data);

                BeginReadAsync();
            }

            protected readonly byte[] _buffer = new byte[4096];

            private StreamReader _reader;

            public delegate void EventHandler<args>(object sender, string data);
        }
    }
}