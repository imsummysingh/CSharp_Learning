using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//octal number system example
namespace _11_OctalNumberSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec1 = 289;

            string octal1 = Convert.ToString(dec1, 8); //decimarl to octal
            Console.WriteLine(octal1);


            int dec2 = Convert.ToInt32(octal1, 8);     //octal to decimal
            Console.WriteLine(dec2);



            Console.ReadLine();
        }
    }
}
