using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MultiDimensional Array Example
namespace H_106_MultiDimesnionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //multi-dimenaional array 4*3
            int[,] a = new int[4, 3]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 },
                {10,11,12 }
            };

            //read data from multi-dimenional array
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j]); //Row 0, Col 0 -> Row 0, Col 1-> Row 0, Col 2
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
