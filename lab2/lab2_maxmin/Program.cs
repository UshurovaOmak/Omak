using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\example.txt";
            FileStream fread = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);            
            StreamReader sr = new StreamReader(fread);

            string line = sr.ReadToEnd();

            sr.Close();
            fread.Close();
            
            string[] arr = line.Split(';');

            int maks = 0;
            int min = 1000000000;
            for (int i = 0; i < arr.Length; i++)
            {
                int convertedSymbol = int.Parse(arr[i]);
                if (convertedSymbol > maks)
                {
                    maks = convertedSymbol;
                }
                if (convertedSymbol < min)
                {
                    min = convertedSymbol;
                }
            }


            Console.WriteLine("Max is " + maks);
            Console.WriteLine("Min is " + min);
            Console.ReadKey();
        }
    }
}
