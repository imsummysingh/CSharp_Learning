using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//IEnumerable Example
namespace H_145_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a collection
            IEnumerable<string> messages = new List<string>() { "Hello", "Hi", "How are you?" };

            //accessing data
            Console.WriteLine("IEnumerable:");
            foreach(string m in messages)
            {
                Console.WriteLine(m);
            }

            Console.ReadLine();
        }
    }
}
