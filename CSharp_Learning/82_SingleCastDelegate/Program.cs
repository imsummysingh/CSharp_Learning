using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Single cast delegate example
namespace _82_SingleCastDelegate
{
    //Sample class
    class Sample
    {
        //target method
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }

    //delgate
    public delegate int MyDelegateType(int a,int b);


    class Program
    {
        static void Main(string[] args)
        {
            //create object of sample class
            Sample s = new Sample();

            //create deleagte or delegate object
            MyDelegateType del;

            //add method reference to delegate
            del = new MyDelegateType(s.Add);

            //invoking add method using delegate object
            //del.Invoke(2,3);
            Console.WriteLine(del.Invoke(2, 3));

            Console.ReadKey();

        }
    }
}
