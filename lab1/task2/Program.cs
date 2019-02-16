using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class student  //create class student
    {
        private string name;  //parametres of class
        private string id;
        private int year;
        public student(string NAME, string ID, int Year)
        {
            name = NAME;
            id = ID;
            year = Year;
        }
        public void output()  //the method of output
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
        public int increment()  //the method of increment
        {
            return year++;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string s = Console.ReadLine();  //create string s
            string i = Console.ReadLine();  //create string i
            int y = int.Parse(Console.ReadLine());  //create integer for year
            student s1 = new student(s, i, y);   //create new class 
            s1.increment();
            s1.output();
        }
    }
}
