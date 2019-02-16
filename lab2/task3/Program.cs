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
        static string s = " ";  //create a space
        static void f(DirectoryInfo dir, int k) //recursive function that prints info about directory
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen; //color of folders
            for (int i = 0; i < k; i++)
            {
                Console.Write(s); //output spaces
            }
            Console.WriteLine(dir.Name); //output name of folder
            var x = dir.GetFileSystemInfos(); 
            foreach (var t in x)
            {
                if (t.GetType() == typeof(DirectoryInfo))   //if it's folder we call function with more spaces
                {
                    DirectoryInfo y = t as DirectoryInfo;
                    f(y, k + 1);
                }
                if (t.GetType() == typeof(FileInfo))  //if it's file just print the name of file
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;  //the color of file
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
            f(dirinfo, 0);  //calling function

        }
    }
}
