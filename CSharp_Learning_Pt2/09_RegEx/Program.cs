using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


//regular expression exaample
namespace _09_RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //regex
            //for digits
            //Regex regex = new Regex("[0-9]");

            //accept multiple characters - but contains one or more digits  (*)
            //^->Value beign
            //$->value end
            Regex regex = new Regex("^[0-9]*$");

            Console.ReadLine();
        }
    }
}
