using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kiwiwallpaper
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    
    public partial class App : Application
    {
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpClassName, string lpWindowName);

        public const int WM_CLOSE = 0x10;
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int SystemParametersInfo(
         int uAction,
         int uParam,
         string lpvParam,
         int fuWinIni
         );
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SystemParametersInfo(uint uAction, uint uParam, StringBuilder lpvParam, uint init);

        private void OnExit(object sender, ExitEventArgs e)
        {

            IntPtr closeHwnd = FindWindow(null, "Test Window");
            if (closeHwnd != IntPtr.Zero)
            {
                SendMessage(closeHwnd, WM_CLOSE, 0, 0);
            }
            else {
                MessageBox.Show("closeHwnd fail!.");
            }
            //ResetWallpaper.ReSet();
            SystemParametersInfo(20, 0, "C:\\Users\\Richard\\Desktop\\copy.bmp", 0x2);
            //Application.Current.Shutdown();
        }
       
    }
    

}
