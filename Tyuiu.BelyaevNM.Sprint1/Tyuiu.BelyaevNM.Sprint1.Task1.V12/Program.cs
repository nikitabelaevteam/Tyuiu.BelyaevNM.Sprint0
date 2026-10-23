using System;
using Tyuiu.BelyaevNM.Sprint1.Task1.V12.Lib;
namespace Tyuiu.BelyaevNM.Sprint1.Task1.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Беляев Н. М. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Беляев Никита Михайлович | ПКТб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (5*2 - 2) / 4 * 3.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = DataService.Calculate();
            Console.WriteLine("Результат вычисления выражения равен: " + res);

            Console.ReadKey();
        }
    }
}
