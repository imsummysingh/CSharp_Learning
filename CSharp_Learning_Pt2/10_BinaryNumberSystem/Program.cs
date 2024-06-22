﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Binary Example
namespace _10_BinaryNumberSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec1 = 13;

            string binary1 = Convert.ToString(dec1, 2); //decimarl to binary
            Console.WriteLine(binary1);


            int dec2 = Convert.ToInt32(binary1, 2);     //binary to decimal
            Console.WriteLine(dec2);

            //binary literals
            int n = 0b1100100;  //100   ->0b stands for binary
            Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
