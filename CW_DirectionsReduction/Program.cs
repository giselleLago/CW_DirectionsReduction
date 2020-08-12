using System;

namespace CW_DirectionsReduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new DirReduction();
            Console.WriteLine(a.dirReduc(new string[] { "NORTH", "SOUTH", "WEST", "EAST" }));
            Console.ReadKey();
        }
    }
}
