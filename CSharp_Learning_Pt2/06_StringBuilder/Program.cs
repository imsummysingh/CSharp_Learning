using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "Hey", "How", "are", "you" };

            //Output: Hey how are you


            //with string
            //this will lead to memory wastage
            string sentence = "";
            foreach(string w in words)
            {
                sentence = sentence + " " + w;  //new object will be created in each iteration.
            }
            Console.WriteLine(sentence);


            //string Builder
            StringBuilder builder = new StringBuilder();
            foreach(string w in words)
            {
                builder.Append(w);  //only one object is created and that is used in all the iteration
                builder.Append(" ");
            }
            Console.WriteLine(builder.ToString());
            Console.WriteLine(builder.Capacity);
            Console.WriteLine(builder.Length);  //also same as capacity

            Console.ReadLine();
        }
    }
}
