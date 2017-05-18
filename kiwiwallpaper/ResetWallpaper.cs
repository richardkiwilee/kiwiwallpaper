using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace kiwiwallpaper
{
    public static class ResetWallpaper
    {
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int SystemParametersInfo(
         int uAction,
         int uParam,
         string lpvParam,
         int fuWinIni
         );
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SystemParametersInfo(uint uAction, uint uParam, StringBuilder lpvParam, uint init);

        const uint SPI_GETDESKWALLPAPER = 0x0073;
        static StringBuilder wallPaperPath = new StringBuilder(200);
        public static void GetOrigin() {
            if (SystemParametersInfo(SPI_GETDESKWALLPAPER, 200, wallPaperPath, 0))
            {
                System.Console.WriteLine("Get Origin Path:");
                System.Console.WriteLine(wallPaperPath.ToString());
            }
            else {
                System.Console.WriteLine("Error: can't load wallpaper path.");
            }
        }
    
        public static void ReSet()
        {
            
            string path = wallPaperPath.ToString();
            string temp = "C:\\Users\\Richard\\Desktop\\temp.bmp";
            //this temp file canot be deleted.
            //if you do so,the next time GetOrigin() will fail.

            //System.IO.FileInfo fi_temp = new FileInfo(temp);
            //if (fi_temp.Exists)
            //{
            //    fi_temp.Delete();
            //}
            System.IO.FileInfo fi_path = new FileInfo(path);
            if (fi_path.Exists)
            {
                Image image = Image.FromFile(path);
                image.Save(temp, System.Drawing.Imaging.ImageFormat.Bmp);
                SystemParametersInfo(20, 0, temp, 0x2);
            }
            else
            {
                SystemParametersInfo(20, 0, "C:\\Users\\Richard\\Desktop\\copy.bmp", 0x2);
            }
        }
    
    }
    
}
