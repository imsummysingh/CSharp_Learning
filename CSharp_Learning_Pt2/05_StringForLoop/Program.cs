using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_StringForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "developer@gmail.com";

            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };


            //way 1
            //for loop
            int vowelCount = 0;
            for(int i = 0; i < name.Length; i++)   
            {
                bool isMatch = false;
                for(int j = 0; j < vowels.Length; j++)
                {
                    if (name[i] == vowels[j])
                        isMatch = true;
                }
                if (isMatch)
                    vowelCount++;
                Console.WriteLine(name[i] + " " + isMatch);
            }
            Console.WriteLine("Total Vowels: " + vowelCount);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //way 2
            //using methods of array/collection
            int count = 0;
            for(int i = 0; i < name.Length; i++)
            {
                if(Array.IndexOf(vowels, name[i]) >= 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Vowels Count: " + count);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //way 3
            //using linq
            //name.Count(ch=>true)
            Console.WriteLine(name.Count(ch => Array.IndexOf(vowels, ch) >= 0));
            


            Console.ReadLine();
        }
    }
}
