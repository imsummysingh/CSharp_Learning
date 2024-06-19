using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Iterator Example
namespace H_147_IteratorExample
{
    class Sample
    {
        public IEnumerable<int> Method()
        {
            Console.WriteLine("Iterator method executes");
            yield return 10;
            Console.WriteLine("Iterator method continues");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            var enumerable1 = s.Method();
            
            //way 1
            //var enumerator1 = enumerable1.GetEnumerator();
            //enumerator1.MoveNext();
            //Console.WriteLine(enumerator1.Current);
            //enumerator1.MoveNext();

            //way2
            foreach(var item in enumerable1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
