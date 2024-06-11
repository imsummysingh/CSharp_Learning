using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Expression Bodied Members Example
namespace _95_ExpressionBodiedMembersExample
{
    class Student
    {
        private string _studentName;

        //public method
        //Method using Expression Bodied Members 
        public int GetStudentNameLength() => _studentName.Length;

        //public constructor
        //public Student() => Console.WriteLine("Constructor using Expression Bodied Members");
        public Student() => _studentName = "Ranjeet";

        //public properties
        public string StudentName
        {
            set => _studentName = value;
            get => _studentName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student() { StudentName = "Ranjeet Kumar" };
            Console.WriteLine(s.StudentName);
            Console.WriteLine(s.GetStudentNameLength());

            Console.ReadLine();
        }
    }
}
