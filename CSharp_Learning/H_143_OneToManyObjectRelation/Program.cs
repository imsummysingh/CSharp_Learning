using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//one to many object relation example
namespace H_143_OneToManyObjectRelation
{
    class Examination
    {
        public string ExaminationName { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int MaxMarks { get; set; }
        public int SecuredMarks { get; set; }
    }
    class Student
    {
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }

        //ont to many relation
        public List<Examination> examinations { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create student class object
            Student student = new Student();
            student.RollNo = 101;
            student.StudentName = "Ranjeet";
            student.Email = "rjeet30@gmail.com";
            student.examinations = new List<Examination>();
            
            student.examinations.Add(new Examination() { ExaminationName = "DSA", Month = 6, Year = 2023, MaxMarks = 100, SecuredMarks = 86 });
            student.examinations.Add(new Examination() { ExaminationName = "COA", Month = 6, Year = 2023, MaxMarks = 100, SecuredMarks = 67 });
            student.examinations.Add(new Examination() { ExaminationName = "Math", Month = 6, Year = 2023, MaxMarks = 100, SecuredMarks = 56 });

            //access data
            Console.WriteLine("Details:");
            Console.WriteLine("Roll No: " + student.RollNo);
            Console.WriteLine("Name: " + student.StudentName);
            Console.WriteLine("Email: " + student.Email);

            foreach(Examination ex in student.examinations)
            {
                Console.WriteLine(ex.ExaminationName+", "+ex.Month+", "+ex.Year+", "+ex.MaxMarks+", "+ex.SecuredMarks);
            }

            Console.ReadLine();
        }
    }
}
