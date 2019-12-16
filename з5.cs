using System;

namespace Лаб.раб___3_задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("введите х: ");// Ввод х
            x = Convert.ToInt32(Console.ReadLine());// Вывод х
            y = 4 * Math.Pow((x-3), 6) - 7 * Math.Pow((x-3), 3) + 2;
            Console.WriteLine("y= " + y);// Вывод y
            Console.Read();
        }
    }
}
