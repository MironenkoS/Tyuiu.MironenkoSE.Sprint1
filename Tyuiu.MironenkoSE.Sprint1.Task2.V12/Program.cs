using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MironenkoSE.Sprint1.Task2.V12.Lib;
namespace Tyuiu.MironenkoSE.Sprint1.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 Выполнил: Мироненко C.Э АСОИУ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Варинат #12                                                             *");
            Console.WriteLine("* Выполнил: Мроненко Сергей Эдуарлович АСОИУ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая запрашивает у пользователя исходные данные , *");
            Console.WriteLine("* вычисляет результат обьема параллелепипеда и печатает eго на экран.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value,valueTwo,valueTree;
            Console.WriteLine("Видите значение a");
            value=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Видите значение b");
            valueTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Видите значение c");
            valueTree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Обьем параллеепиеда = " + ds.CalculateParallelepipedVolume(value, valueTwo, valueTree));
            Console.ReadLine();



        }
    }
}
