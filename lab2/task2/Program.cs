using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2task2
{
    class Program
    {
        static bool f(int n)
        {
            if (n <= 1) return false;
            else
            {
                bool k = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        k = false;
                        break;

                    }
                }
                return k;
            }
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Айгерим Мукышева\source\repos\week2\lab2task2\lab2task2\bin\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader s = new StreamReader(fs);
            string l = s.ReadLine();
            string[] a = l.Split();
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            string path = @"C:\Users\Айгерим Мукышева\source\repos\week2\lab2task2\lab2task2\bin\output.txt";
            File.Create(path).Close();
            FileStream fs1 = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter r = new StreamWriter(fs1);
            for (int i = 0; i < b.Length; i++)
            {
                if (f(b[i]) == true)
                {
                    r.Write(b[i] + " ");
                }
            }
            r.Close();
            fs.Close();
            s.Close();
        }
    }
}
