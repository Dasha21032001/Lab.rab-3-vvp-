using System;

namespace Лаб.раб__3_задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, k, l, m;
            Console.WriteLine("Введите первоначальное значение переменной А:");
            A = Convert.ToInt32(Console.ReadLine());// Вывод начального значения А
            Console.WriteLine("Введите первоначальное значение переменной B:");
            B = Convert.ToInt32(Console.ReadLine());// Вывод начального значения В
            Console.WriteLine("Введите первоначальное значение переменной C:");
            C = Convert.ToInt32(Console.ReadLine());// Вывод начального значения C
            k = A; l = B; m = C; A = m; B = k; C = l; 
            Console.WriteLine("Новое значение А:" + A);// Вывод нового значения А
            Console.WriteLine("Новое значение В:" + B);// Вывод нового значения В
            Console.WriteLine("Новое значение C:" + C);// Вывод нового значения C
            Console.ReadKey();
        }
    }
}
