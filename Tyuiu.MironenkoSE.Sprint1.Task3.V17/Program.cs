using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MironenkoSE.Sprint1.Task3.V17.Lib;
namespace Tyuiu.MironenkoSE.Sprint1.Task3.V17
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
            Console.WriteLine("* Варинат #22                                                             *");
            Console.WriteLine("* Выполнил: Мроненко Сергей Эдуарлович АСОИУ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая запрашивает у пользователя исходные данные , *");
            Console.WriteLine("* вычисляет результат по формуле (5+x)/(y*x) и печатает eго на экран.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x = 5.101;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.ZeroCheck(x));
            Console.ReadKey();
           
        }
    }
}
