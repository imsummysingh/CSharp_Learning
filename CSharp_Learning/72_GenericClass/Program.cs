using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Generic class example
namespace _72_GenericClass
{
    //Generic class User
    class User<T>
    {
        //generic field
        public T RegistrationStatus;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating obkect for the generic class ->int
            User<int> u1 = new User<int>();
            //accesing the generic field of the generic class user
            u1.RegistrationStatus = 101;
            Console.WriteLine("Registration No:" + u1.RegistrationStatus);



            //Second object ->bool
            User<bool> u2 = new User<bool>();
            u2.RegistrationStatus = true;
            Console.WriteLine("Registration is:" + u2.RegistrationStatus);


            //thirs object -> String
            User<String> u3 = new User<string>();
            u3.RegistrationStatus = "Active";
            Console.WriteLine("Registration Status is:" + u3.RegistrationStatus);

            Console.ReadLine();
        }
    }
}
