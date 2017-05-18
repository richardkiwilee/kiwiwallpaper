using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Documents;
using System.Windows;


namespace kiwiwallpaper
{
    class WriteBuffer
    {
        List<string> _index_ = new List<string>();
        private int count_file=0;
        public void GetIndex()
        {
            
            System.IO.DirectoryInfo folder = new System.IO.DirectoryInfo(@"D:\steam\steamapps\workshop\content\431960\");
            if (!folder.Exists)
            {
                MessageBox.Show("Path doesnt exist!");
                return;
            }
            
            foreach (DirectoryInfo dChild in folder.GetDirectories("*"))
            { 
                //Console.Write(dChild.Name + "\n");
                //Console.Write(dChild.FullName + "\n");
                _index_.Add(dChild.Name);
                count_file++;
            }
            Console.WriteLine( count_file + " files have been read.\n");
            for (int i = 0; i < count_file; i++)
            {
                Console.WriteLine(_index_[i]);
            }
        }

    }
}
