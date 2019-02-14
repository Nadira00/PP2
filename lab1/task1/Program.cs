using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task1
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
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] a = s.Split();
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (f(b[i]) == false) b[i] = 0;
                else cnt++;
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < n; i++)
            {
                if (b[i] != 0) Console.Write(b[i] + " ");
            }

        }
    }
}
