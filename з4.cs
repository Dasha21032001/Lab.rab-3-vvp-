using System;

namespace лаб.раб__3_задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("введите х: ");// Ввод х
            x = Convert.ToInt32(Console.ReadLine());// Вывод х
            y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
            Console.WriteLine("y= " + y);// Вывод y
            Console.Read();
        }
    }
}
