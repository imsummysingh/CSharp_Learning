using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Muliple generic parameters example
namespace _73_MultipleGenericParameters
{
    //Generic class User
    class User<T1, T2>
    {
        //generic field
        public T1 RegistrationStatus;
        public T2 Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating obkect for the generic class ->int & int
            User<int,int> u1 = new User<int,int>();
            //accesing the generic field of the generic class user
            u1.RegistrationStatus = 101;
            u1.Age = 29;
            Console.WriteLine("Registration No:" + u1.RegistrationStatus);
            Console.WriteLine("Age:" + u1.Age);

            //creating obkect for the generic class ->string & int
            User<string, int> u2 = new User<string, int>();
            //accesing the generic field of the generic class user
            u2.RegistrationStatus = "Active";
            u2.Age = 27;
            Console.WriteLine("Registration Status:" + u2.RegistrationStatus);
            Console.WriteLine("Age:" + u2.Age);


            Console.ReadLine();

        }
    }
}
