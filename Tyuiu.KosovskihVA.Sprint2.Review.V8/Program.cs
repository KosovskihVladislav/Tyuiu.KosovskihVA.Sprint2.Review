using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskihVA.Sprint2.Review.Lib;

namespace Tyuiu.KosovskihVA.Sprint2.Review.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2(Review) | Выполнил: Косовских В.А. | ПКТБ-23-2";
            Console.WriteLine("*************************************************************");
            Console.WriteLine("* Спринт #2 Review                                          *");
            Console.WriteLine("* Таск: #7                                                  *");
            Console.WriteLine("* Вариант: #8                                               *");
            Console.WriteLine("* Выполнил: Косовских Владислав Алексеевич | ИСТНб-23-1     *");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                  *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение           *");
            Console.WriteLine("* и печатает результат на экране.                           *");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                          *");
            Console.WriteLine("*************************************************************");

            Console.Write("Введите значение x : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y : ");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("*************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                *");
            Console.WriteLine("*************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("Попадает");
            }
            else
            {
                Console.WriteLine("Не попадает");
            }
            

            Console.ReadKey();
        }
    }
}
