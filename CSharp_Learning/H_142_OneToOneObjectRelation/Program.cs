using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//One to One Object Relation Example
namespace H_142_OneToOneObjectRelation
{
    class Branch
    {
        //properties
        public string BranchName { get; set; }
        public int NoOfSubjects { get; set; }
    }
    class Student
    {
        //properties
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        
        //one to one 
        //Contains reference to object of Branch class, that represents the branch that the current student belongs to.
        public Branch branch { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //student class object
            Student student = new Student();
            student.RollNo = 101;
            student.StudentName = "Ranjeet";
            student.Email = "rjeet30@gmail.com";

            //Way2
            student.branch = new Branch();
            student.branch.BranchName = "Computer Science";
            student.branch.NoOfSubjects = 48;

            //Display Values
            Console.WriteLine("Student Details:");
            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.branch.BranchName);
            Console.WriteLine(student.branch.NoOfSubjects);

            //Way-2
            //branch class object

            //Branch br = new Branch();
            //br.BranchName = "Computer Science";
            //br.NoOfSubjects = 48;


            //ont-to-one relation
            //student.branch = br;


            Console.ReadLine();
        }
    }
}
