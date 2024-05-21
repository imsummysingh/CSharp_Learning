using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//out variable declaration-c#7.0
namespace _27_outVariableDeclaration
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
            //-----int n, m;     - this was happening before out variable decalaration
            Program p = new Program();

            ////we can specify the type with out modifier in the method calling and declare the argument variable
            /////no need of declaring the variable before calling the method
            p.Sum(out int n, out int m);    


            //It will work same as 'out' modifier keyword, just the changes is the above way of writing code with c#7.0
            //The value of n & m is un-initialzied and it will fetch those values from the paramaters in the method definition
            Console.WriteLine("The value of argument n is from paramater x is:" + n);
            Console.WriteLine("The value of argument m is from paramater y is:" + m);

            Console.ReadLine();
        }
    }
}
