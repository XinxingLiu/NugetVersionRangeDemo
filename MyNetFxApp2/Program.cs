using MyLibrary;
using System;

namespace MyNetFxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before calling constructor");
            Class1 class1 = new Class1();
            Console.WriteLine("Constructed");
            class1.LoadNethereum();
            Console.WriteLine("Called LoadNethereum");
            Console.ReadKey();
        }
    }
}
