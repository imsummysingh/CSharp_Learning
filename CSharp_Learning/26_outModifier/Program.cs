using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//out keyword modifier for the paramater and arguments
namespace _26_outModifier
{
    class Program
    {
        //method paramaters are x&y in the method definition
        public void Sum(out int x, out int y)  //variable are not-initialized here and we can initialize it later inside the method    
        {
            x = 5;
            y = 4;
            Console.WriteLine("The sum of two out paramater is:" + (x + y));
        }
        static void Main(string[] args)
        {
            //decalring out variable as arguments whill be used in method calling
            int n, m;
            Program p = new Program();
            p.Sum(out n, out m);

            //The value of n & m is un-initialzied and it will fetch those values from the paramaters in the method definition
            Console.WriteLine("The value of argument n is from paramater x is:" + n);
            Console.WriteLine("The value of argument m is from paramater y is:" + m);

            Console.ReadLine();
        }
    }
}
