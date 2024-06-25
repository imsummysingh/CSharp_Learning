using System.Runtime.CompilerServices;

namespace Initializer
{
    internal class Initializer1
    {
        [ModuleInitializer]
        internal static void Initlaize1()
        {
            Console.WriteLine("From Initialzie1");
        }
    }
}