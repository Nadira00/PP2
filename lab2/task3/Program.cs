using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2task3
{
    class Program
    {
        static string s = " ";
        static void f(DirectoryInfo dir, int k)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < k; i++)
            {
                Console.Write(s);
            }
            Console.WriteLine(dir.Name);
            var x = dir.GetFileSystemInfos();
            foreach (var t in x)
            {
                if (t.GetType() == typeof(DirectoryInfo))
                {
                    DirectoryInfo y = t as DirectoryInfo;
                    f(y, k + 1);
                }
                if (t.GetType() == typeof(FileInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 0; i < k + 1; i++)
                    {
                        Console.Write(s);
                    }
                    Console.WriteLine(t);
                }

            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Users\Айгерим Мукышева\source");
            f(dirinfo, 0);

        }
    }
}
