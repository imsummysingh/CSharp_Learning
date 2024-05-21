using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//ref returns example
namespace _29_refreturn
{
    class Student
    {
        //public field
        public int grade = 2;

        //public method
        public void PrintGrade()
        {
            Console.WriteLine("Grade:" + grade);
        }

        //public method with ref return <- method definiton
        public ref int DoWork()     //-ref1
        {
            //return the reference of the 'grade' field
            //not just returning the value of the grade, but we return the reference of the grade field.
            return ref grade;       //-ref2
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating obj for the student
            Student s = new Student();

            //calling print garde method
            s.PrintGrade();     //2

            //Calling dowork method.
            ref int g = ref s.DoWork();     //-ref3 & --ref4

            //updating the value of 'ref return'
            g = 5;      //the value 5 will be updated to the original variable 'g'

            s.PrintGrade();         //5

            Console.ReadLine();
        }
    }
}
