using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//Expression Tree Example - Complex Example
namespace _94_ExpressionTreeExample2
{
    //class student
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create student object
            Student s = new Student() { StudentId = 101, StudentName = "Ranjeet", Age = 29 };

            //create expression tree with func
            Expression<Func<Student, bool>> expression = st => st.Age>20 && st.Age<30;

            //compile expression using compile method invoke it as delegate
            Func<Student, bool> myDel = expression.Compile();

            //execute the method
            bool result = myDel.Invoke(s);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
