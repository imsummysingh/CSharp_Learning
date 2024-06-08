using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Generic Method Example
namespace _74_GenericMethodExample
{
    //Class Employee
    class Employee
    {
        public int salary;
    }
    //class Student
    class Student
    {
        public int marks;
    }

    //class with generic Method
    class GenericClass
    {
        public void PrintData<T>(T obj) where T:class
        {
            if (obj.GetType() == typeof(Student))
            {
                Student temp = obj as Student;
                Console.WriteLine(temp.marks);                    
            }
            else if (obj.GetType() == typeof(Employee))
            {
                Employee temp = obj as Employee;
                Console.WriteLine(temp.salary);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating objects
            GenericClass gc = new GenericClass();
            Employee e = new Employee() { salary = 2000 };
            Student s = new Student() { marks = 69 };

            //call the generic method
            gc.PrintData<Employee>(e);
            gc.PrintData<Student>(s);

            Console.ReadLine();
        }
    }
}
