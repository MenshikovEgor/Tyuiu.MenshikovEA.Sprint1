using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint1.Task3.V9.Lib;

namespace Tyuiu.MenshikovEA.Sprint1.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество минут:");

            string min = Console.ReadLine();
            int minutes = Convert.ToInt32(min);

            Console.WriteLine("Количество минут равняется " + minutes);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(minutes + " минут(ы) это " + ds.ConvertMinutesToHours(minutes) + " часа(ов) и " + ds.ConvertMinutesToMinutes(minutes) + " минут(ы)");

            Console.ReadKey();
        }
    }
}
