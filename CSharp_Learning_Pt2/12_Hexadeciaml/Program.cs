using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Hexadecimal Numbersystem example
namespace _12_Hexadeciaml
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec1 = 742;

            string hex1 = Convert.ToString(dec1, 16); //decimarl to hexadecimal
            Console.WriteLine(hex1);


            int dec2 = Convert.ToInt32(hex1, 16);     //hexadecimal to decimal
            Console.WriteLine(dec2);



            Console.ReadLine();
        }
    }
}
