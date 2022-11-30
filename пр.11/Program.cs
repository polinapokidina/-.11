using System;

namespace Задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, z = 0.001, q = 0, s = 0, x = 0.15;
            int n = 0;
            a = x;
            s = a;
            while (Math.Abs(a) > z)
            {
                q = x * x / (4 * n * n + 1) / (4 * n * n - 1);
                a *= q;
                s += a;
                n++;
            }
            Console.WriteLine();
            Console.WriteLine("Результат");
            Console.WriteLine();
            Console.WriteLine("Сумма s=" + Convert.ToString(s));
            Console.WriteLine("Число членов ряда n=" + Convert.ToString(n));
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
        }
    }
}