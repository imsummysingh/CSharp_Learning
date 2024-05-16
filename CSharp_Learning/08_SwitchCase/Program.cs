using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Switch case example
namespace _08_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade = 'B';

            //find out description based on the grade

            string gradeDesciprion;
            switch (grade)
            {
                case 'O':
                    gradeDesciprion = "Outstanding";
                    break;
                case 'A':
                    gradeDesciprion = "Excellent";
                        break;
                case 'B':
                    gradeDesciprion = "Good";
                    break;
                case 'C':
                    gradeDesciprion = "Average";
                    break;
                default:
                    gradeDesciprion = "Fail";
                    break;
            }
            Console.WriteLine(gradeDesciprion);
            Console.ReadLine();
        }
    }
}
