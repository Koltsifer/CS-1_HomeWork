//1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.

using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n, sn, a, h, w;
            Console.WriteLine("Anketa");

            Console.Write("Name: ");
            n = Console.ReadLine();
            Console.Write("SureName: ");
            sn = Console.ReadLine();
            Console.Write("Age: ");
            a = Console.ReadLine();
            Console.Write("Height: ");
            h = Console.ReadLine();
            Console.Write("Weight: ");
            w = Console.ReadLine();

            Console.WriteLine("Full Name: " + n + " " + sn + ", Age: " + a + ", Height: " + h + ", Weight: " + w);
            Console.WriteLine("Full Name: {0} {1}, Age: {2}, Height: {3}, Weight: {4}",n ,sn ,a ,h ,w);
            Console.WriteLine($"Full Name: {n} {sn}, Age: {a}, Height: {h}, Weight: {w}");

            Console.ReadKey();
        }
    }
}
