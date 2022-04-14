using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Укажите номер задачи");
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Task1();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Task2();
                        Console.Clear();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Task3();
                        Console.Clear();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Task4();
                        Console.Clear();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Task5();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (key.Key != ConsoleKey.Escape);
        }
        static void Task1()
        {

        }

        static void Task2()
        {

        }

        static void Task3()
        {

        }

        static void Task4()
        {

        }

        static void Task5()
        {

        }
    }
}
