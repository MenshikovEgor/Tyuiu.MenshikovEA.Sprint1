using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint1.Task7.V25.Lib;

namespace Tyuiu.MenshikovEA.Sprint1.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Меньшиков Е. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Меньшиков Егор Александрович | ИИПб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя переменные и     *");
            Console.WriteLine("* выводит результат результат вычислений по формуле с переменными,        *");
            Console.WriteLine("* введёнными пользователем.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                 2            3            2                             *");
            Console.WriteLine("*        x      y   + 6 + cos(x ) + xy - 2x                               *");
            Console.WriteLine("*  z = e   -  -------------------------------                             *");
            Console.WriteLine("*                       4                                                 *");
            Console.WriteLine("*                  sin(x + 13) + 9y - 2                                   *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение переменной z приблизительно равняется " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
