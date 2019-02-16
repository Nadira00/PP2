using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task4
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine()); //the number of numbers
            int[,] b = new int[n, n];  //create two-dimensional array
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();  //this is like endl in c++
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");  
                }
            }


        }
    }
}
