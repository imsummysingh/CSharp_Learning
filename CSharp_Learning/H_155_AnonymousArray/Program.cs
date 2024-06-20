using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Anonymous Array Example
namespace H_155_AnonymousArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating anonymous array/ implicitly typed array
            var person = new[]
            {
                new {PersonName = "Ranjeet", Age=29},
                new {PersonName ="Vicky", Age = 27},
                new {PersonName = "Vishal", Age=28},
                new {PersonName ="Mani", Age = 28}
            };

            foreach (var item in person)
            {
                Console.WriteLine(item.PersonName + "," + item.Age);
            }

            Console.ReadLine();
        }
    }
}
