using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ConvertAll method in collection Example
namespace H_133_ConvertAllMethodCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 3, 5, 7, 9, 11 };

            //convert collection int to string
            List<string> newList=list.ConvertAll<string>((n) =>
            {
                return Convert.ToString(n);
            });

            //accesing the converted value
            foreach(string i in newList)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
