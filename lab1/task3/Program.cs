using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //create number of numbers
            string s = Console.ReadLine();
            string[] q = s.Split(); //initial array of strings
            for(int i = 0; i < n; i++)
            {
                for(int j=0;j<2;j++) //i=2j
                {
                    Console.Write(arg[i] + " ");
                }
                    
            }
           
        }
    }
}