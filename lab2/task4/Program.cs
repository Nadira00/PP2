using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();
            string path1 = @"C:\Users\Айгерим Мукышева\source";
            string path2 = @"C:\Users\Айгерим Мукышева\source\repos\week2\lab2task4\lab2task4\bin\";
            string sourcefile = Path.Combine(path1, filename);
            string destfile = Path.Combine(path2, filename); FileStream fs = File.Create(sourcefile);
            fs.Close();
            File.Copy(sourcefile, destfile, true);
            File.Delete(sourcefile);
        }
    }
}
