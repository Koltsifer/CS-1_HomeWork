//4.Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.

using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Nmber Switcher");

            Console.Write("Input a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Normal a, b:   {a} {b}");

            a = b - a;
            b = b - a;
            a = b + a;

            Console.WriteLine($"Inverted a, b: {a} {b}");

            Console.ReadKey();



            /*
            int a, b, c;
            c = 0;
            Console.WriteLine("Nmber Switcher");

            Console.Write("Input a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Normal a, b:   {a} {b}");

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"Inverted a, b: {a} {b}");

            Console.ReadKey();
            */
        }
    }
}
