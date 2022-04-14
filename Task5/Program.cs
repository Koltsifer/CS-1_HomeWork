//5.
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организовать в центре экрана.
//в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).

using System;

namespace Task5
{
    internal class Program
    {
        static void WindowSet(int x,int y)
        {
            Console.SetWindowSize(x, y);
            Console.SetBufferSize(x, y);
        }
        static void PrintXY(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
        static void Main(string[] args)
        {
            //Console.SetWindowSize(100, 25);
            //Console.SetBufferSize(100, 25);
            WindowSet(100, 25);
            string n, sn, c;
            Console.WriteLine("Info");

            Console.Write($"Name: ");
            n = Console.ReadLine();
            Console.Write($"Surename: ");
            sn = Console.ReadLine();
            Console.Write($"City: ");
            c = Console.ReadLine();

            PrintXY($"Info: {n} {sn}, {c}.", 35, 12);
            //Console.SetCursorPosition(35, 12);
            //Console.WriteLine($"Info: {n} {sn}, {c}.");

            Console.ReadKey();
        }
    }
}
