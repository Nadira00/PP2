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
            string filename = Console.ReadLine();  //to give name to new file
            string path1 = @"C:\Users\Айгерим Мукышева\source";  //path where we will create new file
            string path2 = @"C:\Users\Айгерим Мукышева\source\repos\week2\lab2task4\lab2task4\bin\";  //path where  we will copy first file
            string sourcefile = Path.Combine(path1, filename);  //combining name of file and path where we will create it
            string destfile = Path.Combine(path2, filename);  //combining like first
            FileStream fs = File.Create(sourcefile); //creating it actually
            fs.Close();  //we should close it in order to working with new file
            File.Copy(sourcefile, destfile, true);  //copy
            File.Delete(sourcefile);  //delete
        }
    }
}
