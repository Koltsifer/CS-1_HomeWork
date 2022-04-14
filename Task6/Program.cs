//6. * Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

using System;

namespace Task6
{
    internal class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        static void Pause(string ms)
        {
            Console.WriteLine(ms);
            Console.ReadKey();
        }

        static void PrintXY(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        static void WindowSet(int x, int y)
        {
            Console.SetWindowSize(x, y);
            Console.SetBufferSize(x, y);
        }

        static void Graphic(System.ConsoleColor a, System.ConsoleColor b)
        {
            Console.BackgroundColor = a;  
            Console.ForegroundColor = b;
        }

        static void Main()
        {
            Graphic(ConsoleColor.Yellow, ConsoleColor.Red);
            Console.WriteLine("Hello world");
            Pause();
        }
    }
}
