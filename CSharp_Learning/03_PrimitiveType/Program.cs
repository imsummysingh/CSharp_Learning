using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Program about primitive data type and their min and max values
namespace _03_PrimitiveType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sbyte - 8Bit signed Integer, 1byte in size
            sbyte a = sbyte.MinValue;
            sbyte b = sbyte.MaxValue;
            sbyte c = default(sbyte);

            Console.WriteLine("The min value of sbyte is:{0}", a);
            Console.WriteLine("The max value of sbyte is:{0}", b);
            Console.WriteLine("The default value of sbyte is:{0}", c);

            //Byte - 8bit unsigned integer, 1byte in size
            byte d = byte.MinValue;
            byte e = byte.MaxValue;
            byte f = default(byte);

            Console.WriteLine("The min value of byte is:{0}", d);
            Console.WriteLine("The max value of byte is:{0}", e);
            Console.WriteLine("The default value of byte is:{0}", f);

            //Short - 16bit signed integer, 2byte in size
            short g = short.MinValue;
            short h = short.MaxValue;
            short i = default(short);
            Console.WriteLine("The min value of short is:{0}", g);
            Console.WriteLine("The max value of short is:{0}", h);
            Console.WriteLine("The default value of short is:{0}", i);

            //ushort- 16bit unsigned integer, 2byte in size
            ushort j = ushort.MinValue;
            ushort k = ushort.MaxValue;
            ushort l = default(ushort);
            Console.WriteLine("The min value of ushort is:{0}", j);
            Console.WriteLine("The max value of ushort is:{0}", k);
            Console.WriteLine("The default value of ushort is:{0}",l);

            //Int - 32 bit signed integer, 4byte in size
            int aa = int.MinValue;
            int ab = int.MaxValue;
            int ac = default(int);
            Console.WriteLine("The min value of int is:{0}", aa);
            Console.WriteLine("The max value of int is:{0}", ab);
            Console.WriteLine("The default value of int is:{0}", ac);

            //uint- 32 bit unsigned integer, 4byte in size
            uint ad = uint.MinValue;
            uint ae = uint.MaxValue;
            uint af = default(uint);
            Console.WriteLine("The min value of uint is:{0}", ad);
            Console.WriteLine("The max value of uint is:{0}", ae);
            Console.WriteLine("The default value of uint is:{0}", af);

            //long - 64 big signed integer, 8 byte in size
            long ba = long.MinValue;
            long bb = long.MaxValue;
            long bc = default(long);
            Console.WriteLine("The min value of long is:{0}", ba);
            Console.WriteLine("The max value of long is:{0}", bb);
            Console.WriteLine("The default value of long is:{0}", bc);

            //ulong - 64 bit unsigned integer, 8 byte in size
            ulong bd = ulong.MinValue;
            ulong be = ulong.MaxValue;
            ulong bf = default(ulong);
            Console.WriteLine("The min value of ulong is:{0}", bd);
            Console.WriteLine("The max value of ulong is:{0}", be);
            Console.WriteLine("The default value of ulong is:{0}", bf);

            //float - 32 bit signed floating point number, 4byte in size
            float fa = float.MinValue;
            float fb = float.MaxValue;
            float fc = default(float);
            Console.WriteLine("The min value of float is:{0}", fa);
            Console.WriteLine("The max value of float is:{0}", fb);
            Console.WriteLine("The default value of float is:{0}", fc);

            //double - 64 bit signed floating point numbers, 8byte in size
            double da = double.MinValue;
            double db = double.MaxValue;
            double dc = default(double);
            Console.WriteLine("The min value of double is:{0}", da);
            Console.WriteLine("The max value of double is:{0}", db);
            Console.WriteLine("The default value of double is:{0}", dc);

            //decimal - 128 bit signed floating point number, 16byte in size
            decimal dd = decimal.MinValue;
            decimal de = decimal.MaxValue;
            decimal df = default(decimal);
            Console.WriteLine("The min value of decimal is:{0}", dd);
            Console.WriteLine("The max value of decimal is:{0}", de);
            Console.WriteLine("The default value of decimal is:{0}", df);

            //char - 16 bit single unicode character, 2byte in size
            char ca = char.MinValue;
            char cb = char.MaxValue;
            char cc = default(char);
            char cd = 'C';
            Console.WriteLine("The min value of char is:{0}", ca);
            Console.WriteLine("The max value of char is:{0}", cb);
            Console.WriteLine("The default value of char is:{0}", cc);
            Console.WriteLine("The value of char is:{0}", cd);

            //String- collection of unicode characters, length*2byte in size
            string tutorial = "c# programs";
            Console.WriteLine("The value of string literal is:{0}", tutorial);

            Console.ReadLine();


        }
    }
}
