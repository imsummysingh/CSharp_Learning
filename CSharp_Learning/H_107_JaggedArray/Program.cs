using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Jagged Array Example
namespace H_107_JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating jagged array
            int[][] a = new int[4][];
            a[0] = new int[3] { 10, 20, 30 };
            a[1] = new int[4] { 40, 50, 60, 70 };
            a[2] = new int[2] { 80, 90 };
            a[3] = new int[5] { 1, 2, 3, 4, 5 };

            //read for jagged array
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
