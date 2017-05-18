using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace kiwiwallpaper
{
    public class LoadFromWeb
    {
        private static string url= "http://haxiomic.github.io/projects/webgl-fluid-and-particles/";
        public static string url_return = "";

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpClassName, string lpWindowName);

        public const int WM_CLOSE = 0x10;
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public string GetURL()
        {
            Form form2 = new Form();
            form2.Text = "Load From Web";
            form2.Height =80;
            form2.Width = 600;

            Button OnURLOK = new Button() { Text="OK" };
            OnURLOK.Left =420;
            OnURLOK.Top =10;
            form2.Controls.Add(OnURLOK);            
            OnURLOK.Click += new EventHandler(OnURLOK_Click);
            
            Button OnURLCancel = new Button() { Text = "Cancel" };
            OnURLCancel.Left = 500;
            OnURLCancel.Top = 10;
            form2.Controls.Add(OnURLCancel);
            OnURLCancel.Click += new EventHandler(OnURLCancel_Click);
            
            TextBox URLAdress = new TextBox();
            URLAdress.Left = 10;
            URLAdress.Top = 10;
            URLAdress.AppendText("http://haxiomic.github.io/projects/webgl-fluid-and-particles/");
            URLAdress.Width = 400;
            form2.Controls.Add(URLAdress);
            url_return = URLAdress.Text;

            form2.ShowDialog();
            return url_return;
        }
        private void OnURLOK_Click(object sender, System.EventArgs e)
        {
            IntPtr maindHwnd = FindWindow(null, "Load From Web");
            if (maindHwnd != IntPtr.Zero)
            {
                SendMessage(maindHwnd, WM_CLOSE, 0, 0);
            }
            else
            {
                MessageBox.Show("Can't find the window.");
            }
        }
        private void OnURLCancel_Click(object sender, System.EventArgs e)
        {
            IntPtr maindHwnd = FindWindow(null, "Load From Web");
            if (maindHwnd != IntPtr.Zero)
            {
                url_return = "";
                SendMessage(maindHwnd, WM_CLOSE, 0, 0);
            }
            else
            {
                MessageBox.Show("Can't find the window.");
            }
        }
    }
}
