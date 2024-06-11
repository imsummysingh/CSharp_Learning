using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


//Expression Tree Example
namespace _93_ExpressionTreeExample
{    
    class Program
    {
        static void Main(string[] args)
        {
            //create expression tree with func
            Expression<Func<int, int>> expression = a => a*a;

            //compile expression using compile method invoke it as delegate
            Func<int,int> myDel = expression.Compile();

            //execute the method
            int result = myDel.Invoke(10);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
