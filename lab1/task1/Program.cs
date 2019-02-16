using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task1
{
    class Program
    {
        static bool f(int n)   //creat boolean function to check if number is prime ?
        {
            if (n <= 1) return false;    //prime numbers starts from 2
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
                return k;   //returned to k
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());   //get the number of numbers
            string s = Console.ReadLine();     //create string 
            string[] a = s.Split();            //separate the string
            int[] b = new int[n];            //create the array of numbers
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(a[i]);     //to put string a[i] inside of b[i]
            }
            int cnt = 0;  //create counter of primes
            for (int i = 0; i < n; i++)
            {
                if (f(b[i]) == false) b[i] = 0; 
                else cnt++;
            }
            Console.WriteLine(cnt);   //output the total number of primes
            for (int i = 0; i < n; i++)
            {
                if (b[i] != 0) Console.Write(b[i] + " ");  //output primes
            }

        }
    }
}
