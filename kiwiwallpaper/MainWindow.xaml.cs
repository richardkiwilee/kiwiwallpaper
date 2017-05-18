using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kiwiwallpaper
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {

            InitializeComponent();
            ThreadController.initialize();
            ResetWallpaper.GetOrigin();
        }

        public void OnLoadFromWeb(object sender, RoutedEventArgs args)
        {
            LoadFromWeb OnEvent = new LoadFromWeb();
            OnEvent.GetURL();
            
        }
        public void OnLoadFromFile(object sender, RoutedEventArgs args)
        {
            WriteBuffer LoadFromFile = new WriteBuffer();
            LoadFromFile.GetIndex();
        }
        public void OnConfirm(object sender, RoutedEventArgs args) {

            //var setting = new CefSharp.CefSettings();
            //CefSharp.Cef.Initialize(setting, true, false);


            //var webView = new CefSharp.Wpf.ChromiumWebBrowser();
            //this.Content = webView;

            //webView.Address = "http://www.cnblogs.com/TianFang/";

            //BrowserHelper.OpenDefaultBrowserUrl("http://www.cnblogs.com/TianFang/");

            demo A = new demo();
            A.test();
            
            //when user click twice Onconfirm
            //says you cant create another message route on the single thread.


        }


    }
}
