using System;
using Tyuiu.BelyaevNM.Sprint0.Task5.V0.Lib;
namespace Tyuiu.BelyaevNM.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 + 5 = " + DataService.Addition(1, 5));
            Console.WriteLine("15 - 5 = " + DataService.Subtraction(15, 5));
            Console.WriteLine("10 * 10 = " + DataService.Multiplication(10, 10));
            Console.WriteLine("5 / 5 = " + DataService.Division(5, 5));
            Console.ReadKey();
        }
    }
}
