using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Local function example
namespace _31_LocalFunctions
{
    class Student
    {
        public void DisplayMarks(int m1, int m2, int m3)
        {
            double avgMarks = getAverageMarks();
            Console.WriteLine("Marks1:" + m1);
            Console.WriteLine("Marks2:" + m2);
            Console.WriteLine("Marks3:" + m3);
            Console.WriteLine("Calculating average marks using local function");
            Console.WriteLine("Average marks is:" + avgMarks);

            //creating local function for average marks
            double getAverageMarks()
            {
                //creating local variable for the local function
                double avg;
                avg = (double)(m1 + m2 + m3) / 3;
                return avg;             //we will use this in the same function
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.DisplayMarks(80, 45, 71);

            Console.ReadLine();
        }
    }
}
