using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IEnumerator Example
namespace H_146_IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a collection
            IEnumerable<string> messages = new List<string>() { "Hello", "Hi", "How are you?" };

            //accessing data
            Console.WriteLine("IEnumerable (using foreach loop):");
            foreach (string m in messages)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();



            //IEnumerator
            Console.WriteLine("IEnumerator (way of looping is in use):");
            Console.WriteLine();
            Console.WriteLine("Way 1");
            IEnumerator<string> enumerator = messages.GetEnumerator();
            enumerator.Reset();
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);  //Hello
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);  //Hi
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);  //How are you?
            Console.WriteLine();


            //IEnumerator - way 2
            Console.WriteLine("Way 2");
            IEnumerator<string> enumerator1 = messages.GetEnumerator();
            enumerator1.Reset();
            while (enumerator1.MoveNext())
            {
                Console.WriteLine(enumerator1.Current);
            }



            Console.ReadLine();
        }
    }
}
