using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2task1
{
    class Program
    {


        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Айгерим Мукышева\source\repos\week2\lab2task1\lab2task1\bin\palindr.txt", FileMode.Open, FileAccess.Read);   //create file and open it and read
            StreamReader s = new StreamReader(fs); //reading from file
            string l = s.ReadLine();  //create string for file
            bool k = true;  
            for (int i = 0; i < l.Length; i++)
            {
                if (l[l.Length - i - 1] != l[i])
                {
                    k = false;
                    break;
                }
            }
            if (k == true) Console.WriteLine("YES");
            else Console.WriteLine("NO");
            fs.Close();
            s.Close();

        }
    }
}
