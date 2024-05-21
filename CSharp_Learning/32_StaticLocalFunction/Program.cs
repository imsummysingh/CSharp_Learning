using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Static local function
namespace _32_StaticLocalFunction
{
    class Student
    {
        public void DisplayMarks(int m1, int m2, int m3)
        {
            //double avgMarks = getAverageMarks(m1,m2,m3);
            Console.WriteLine("Marks1:" + m1);
            Console.WriteLine("Marks2:" + m2);
            Console.WriteLine("Marks3:" + m3);
            Console.WriteLine("Calculating average marks using local function");
            //Console.WriteLine("Average marks is:" + avgMarks);

            //creating static local function for average marks
            //static double getAverageMarks(int mark1,int mark2,int mark3)        //only suppoerted in 8.0
            //{
            //    //creating local variable for the local function
            //    double avg;
            //    avg = (double)(mark1 + mark2 + mark3) / 3;
            //    return avg;             //we will use this in the same function
            //}
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
