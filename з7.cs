using System;

namespace Лаб.раб__3_задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, y, x, k;
            Console.WriteLine("введите A: ");// Ввод А
            A = Convert.ToInt32(Console.ReadLine());// Вывод A
            y = Math.Pow(A, 2) * Math.Pow(A, 2) * Math.Pow(A, 2) * Math.Pow(A, 2);
            x = Math.Pow(A, 3) * Math.Pow(A, 2) * Math.Pow(A, 2);
            k = y * x;
            Console.WriteLine("А^15 равно " + k);// Вывод k
            Console.Read();
        }
    }
}
