using System;

namespace лаб.раб__3_задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, y;
            Console.WriteLine("введите A: ");// Ввод A
            A = Convert.ToInt32(Console.ReadLine());// Вывод A
            y =  Math.Pow(A, 2) *  Math.Pow(A, 2) * Math.Pow(A, 2) * Math.Pow(A, 2);
            Console.WriteLine("y= " + y);// Вывод y
            Console.Read();
        }
    }
}
