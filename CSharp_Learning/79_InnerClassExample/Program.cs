using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Inner class Example
namespace _79_InnerClassExample
{
    public class Student
    {
        public int SecuredMarks;
        public int MaxMarks;
        public int Percentage;        
    }
    //outer class
    public class MarksCalculation
    {
        public void CalculatePercentage(Student s)
        {
            //creating object of the inner class to access it's method -> When inner class is private and not public
            //CalculationHelper ch = new CalculationHelper();
            //ch.Multiply(10, 5);

            CalculationHelper ch = new CalculationHelper();            

            s.Percentage = ch.Multiply(s.SecuredMarks / s.MaxMarks, 100);
        }


        //inner class ->Inner class based upon the outer class
        public class CalculationHelper
        {
            public int Multiply(int n1, int n2)
            {
                return n1 * n2;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MarksCalculation.CalculationHelper ch = new MarksCalculation.CalculationHelper();
            Console.WriteLine(ch.Multiply(10, 5));

            MarksCalculation mc = new MarksCalculation();
            Student s = new Student() { SecuredMarks = 30, MaxMarks = 50 };

            mc.CalculatePercentage(s);
            Console.WriteLine(s.Percentage);

            Console.ReadLine();
        }
    }
}
