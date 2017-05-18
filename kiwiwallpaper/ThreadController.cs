using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
namespace kiwiwallpaper
{
    public class ThreadController
    {
        private static IntPtr progman = W32.FindWindow("Progman", null);
        private static IntPtr result = IntPtr.Zero;
        private static IntPtr workerw = IntPtr.Zero;
        public Thread thread = new Thread(ThreadController.WebThread);

        public static void WebThread()
        {
            //load a window deploy the wallpaper.

        }

        public static void initialize()
        {
            #region
            PrintVisibleWindowsHandle.PrintVisibleWindowHandles(2);
            W32.SendMessageTimeout(progman,
                                   0x052C,
                                   new IntPtr(0),
                                   IntPtr.Zero,
                                   W32.SendMessageTimeoutFlags.SMTO_NORMAL,
                                   1000,
                                   out result);
            PrintVisibleWindowsHandle.PrintVisibleWindowHandles(2);
            W32.EnumWindows(new W32.EnumWindowsProc((tophandle, topparamhandle) =>
            {
                IntPtr p = W32.FindWindowEx(tophandle,
                                            IntPtr.Zero,
                                            "SHELLDLL_DefView",
                                            IntPtr.Zero);
                if (p != IntPtr.Zero)
                {
                    workerw = W32.FindWindowEx(IntPtr.Zero,
                                               tophandle,
                                               "WorkerW",
                                               IntPtr.Zero);
                }
                return true;
            }), IntPtr.Zero);   

            #endregion
            
        }
        public static void StartThread() {
            
        }

        public static void SetParent() {
            
            //W32.SetParent(web.Handle, workerw);
        }
        public static void EndThread() {

        }
    }

}
