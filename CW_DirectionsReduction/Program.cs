using System;

namespace CW_DirectionsReduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new DirReduction();
            Console.WriteLine(a.dirReduc(new string[] { "SOUTH", "SOUTH", "EAST", "NORTH", "NORTH", "NORTH", "SOUTH", "NORTH", "EAST", "SOUTH", "EAST", "SOUTH", "SOUTH", "NORTH", "EAST" }));
            Console.ReadKey();
        }
    }
}