using System;

namespace Лаб.раб___3_задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, k, l;
            Console.WriteLine("Введите первоначальное значение переменной А:");
            A = Convert.ToInt32(Console.ReadLine());// Вывод начального значения А
            Console.WriteLine("Введите первоначальное значение переменной B:");
            B = Convert.ToInt32(Console.ReadLine());// Вывод начального значения В
            k = A; l = B; A = l; B = k;
            Console.WriteLine("Новое значение А:"  + A );// Вывод нового значения А
            Console.WriteLine("Новое значение В:" + B );// Вывод нового значения В
            Console.ReadKey();
        }
    }
}
