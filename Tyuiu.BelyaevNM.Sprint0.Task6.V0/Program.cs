using System;
using Tyuiu.BelyaevNM.Sprint0.Task6.V0.Lib;
namespace Tyuiu.BelyaevNM.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraynum = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arraynum));
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(arraynum));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(arraynum));
            Console.ReadKey();
        }
    }
}
