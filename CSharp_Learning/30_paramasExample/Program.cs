using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//paramas modifier example
namespace _30_paramasExample
{
    class Student
    {
        //In the method definition we use params with data type as array
        public void DisplaySubjects(params string[] subjects)
        {
            //for (int i = 0; i <= 6; i++)
            //for(int i = 0; i <= subjects.Length-1; i++)
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine(subjects[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            //Passing multiple no. of arguments in the calling method.
            s.DisplaySubjects("C++", "DSA", "TOC", "CN", "OS", "Discrete Mathematic", "System Design");

            Console.ReadLine();
        }
    }
}
