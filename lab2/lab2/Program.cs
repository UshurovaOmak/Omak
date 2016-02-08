using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\";
                //"C:\\Users\\User\\Documents";//Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(path);
            //Search(dir);

            Stack<DirectoryInfo> items = new Stack<DirectoryInfo>();
            items.Push(dir);

            int cnt = dir.GetFiles().Length;
            Console.WriteLine(cnt + " files are located in " + dir.FullName);

            while (true)
            {
                if (items.Count > 0)
                {
                    DirectoryInfo dirItem = items.Pop();
                    DirectoryInfo[] subDirs = dirItem.GetDirectories();

                    foreach (DirectoryInfo subDirItem in subDirs)
                    {
                        items.Push(subDirItem);
                        cnt = subDirItem.GetFiles().Length;
                        Console.WriteLine(cnt + " files are located in " + subDirItem.FullName);
                    }
                }
                else
                {                    
                    break;
                }
            }

            Console.ReadKey();

        }
        static void Search(DirectoryInfo dir)
        {
            try
            {
                int cnt = dir.GetFiles().Length;
                Console.WriteLine(cnt + " files are located in " + dir.FullName);
                foreach (DirectoryInfo ndir in dir.GetDirectories())
                {
                    Search(ndir);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in folder " + dir.FullName);
            }
        }
    }
}
