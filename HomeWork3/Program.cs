using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Pause() 
        { 
            Console.ReadKey(); 
        }
        static void Pause(string a)
        {
            Console.WriteLine(a);
            Console.ReadKey();
        }

        static int ReadInt()
        {
            bool flag;
            do
            {
                flag = int.TryParse(Console.ReadLine(), out int x);
                if (flag == false) Console.WriteLine("Error!");
                return x;
            } while (flag != false);
        }
        class Complex1
        {
            double a;
            double b;

            public Complex1()
            {
                a = 0;
                b = 0;
            }

            public Complex1(double a, double b)
            {
                this.a = a;
                this.b = b;
            }

            public Complex1 Plus(Complex1 x2)
            {
                Complex1 x3 = new Complex1();
                x3.a = x2.a + b;
                x3.b = x2.b + b;
                return x3;
            }

            public Complex1 Minus(Complex1 x2)
            {
                Complex1 x3 = new Complex1();
                x3.a = x2.a - a;
                x3.b = x2.b - b;
                return x3;
            }

            public Complex1 Multi(Complex1 x2)
            {
                Complex1 x3 = new Complex1();
                x3.a = a * x2.a - b * x2.b;
                x3.b = a * x2.b + b * x2.a;
                return x3;
            }

            public string ToString()
            {
                return a + "+" + b + "i";
            }
        }


        struct Complex
        {
            double a;
            double b;

            public Complex(double a, double b)
            {
                this.a = a;
                this.b = b;
            }

            public Complex Plus(Complex x2)
            {
                Complex x3 = new Complex();
                x3.a = x2.a + a;
                x3.b = x2.b + b;
                return x3;
            }

            public Complex Minus(Complex x2)
            {
                Complex x3 = new Complex();
                x3.a = x2.a - a;
                x3.b = x2.b - b;
                return x3;
            }

            public string ToString()
            {
                return a + "+" + b + "i";
            }
        }

        static void Task1()
        {
            //1.
            //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.
            int a = 2, b = 4;
            Complex complex1 = new Complex(a, a);
            Complex complex2 = new Complex(b, b);

            Complex1 complex3 = new Complex1(a, a);
            Complex1 complex4 = new Complex1(b, b);

            Console.WriteLine("Choose operation.");
            Console.WriteLine("1.Sum.");
            Console.WriteLine("2.Minus.");
            Console.WriteLine("3.Multi.");

            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Complex sum = complex1.Plus(complex2);
                    Console.Clear();
                    Console.WriteLine(sum.ToString());
                    break;

                case ConsoleKey.D2:
                    Complex minus = complex1.Minus(complex2);
                    Console.Clear();
                    Console.WriteLine(minus.ToString());
                    break;

                case ConsoleKey.D3:
                    Complex1 multi = complex3.Multi(complex4);
                    Console.Clear();
                    Console.WriteLine(multi.ToString());
                    break;

                default:
                    break;
            }

            Pause();
        }

        static void Task2()
        {
            //2.
            //а) С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).Требуется подсчитать сумму всех нечётных положительных чисел. 
            //Сами числа и сумму вывести на экран, используя tryParse.

            int a = 0;
            int sum = 0;
            Console.WriteLine("Input 0 to stop." + "\n");
            do
            {
                Console.Write("Input number: ");
                a = ReadInt();

                if (a % 2 == 1) sum += a;

            } while (a != 0);
            Console.WriteLine("\n" + "Odd number sum: " + sum);
            Pause();
        }

        class Fractals
        {
            double a;
            double b;
            double answer;

            public Fractals()
            {
                a = 0;
                b = 0;
                answer = 0;
            }

            public Fractals(double a, double b)
            {
                this.a = a;
                this.b = b;
            }

            public double A
            {
                get { return a; }
                set
                {
                    a = value;
                }
            }

            public double B
            {
                get { return b; }
                set
                {
                    if (value == 0)
                    {
                        Console.WriteLine("\n" + "Знаменатель не может быть равен 0");
                        throw new ArgumentException("Знаменатель не может быть равен 0");
                    }

                    b = value;
                }
            }

            public Fractals Sum(Fractals num2)
            {
                Fractals num3 = new Fractals();
                num3.answer = a / b + num2.a / num2.b;
                return num3;
            }

            public Fractals Minus(Fractals num2)
            {
                Fractals num3 = new Fractals();
                num3.answer = a / b - num2.a / num2.b;
                return num3;
            }

            public Fractals Multi(Fractals num2)
            {
                Fractals num3 = new Fractals();
                num3.answer = (a * num2.a) / (b * num2.b);
                return num3;
            }

            public Fractals Divide(Fractals num2)
            {
                Fractals num3 = new Fractals();
                num3.answer = (a * num2.b) / (b * num2.a);
                return num3;
            }

            public double GetAnswer()
            {
                return answer;
            }
        }

        static void Task3()
        {
            //3.
            //* Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
            //Написать программу, демонстрирующую все разработанные элементы класса.
            //Добавить свойства типа int для доступа к числителю и знаменателю;
            //Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; **Добавить проверку, чтобы знаменатель не равнялся 0.
            //Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); ***Добавить упрощение дробей.
            //Достаточно решить 2 задачи.Все программы сделать в одном решении.

            Fractals num1 = new Fractals();
            Fractals num2 = new Fractals();

            Console.WriteLine("  a1     a2" + "\n" + "  --  +  --" + "\n" + "  b1     b2" + "\n");

            Console.Write("Input a1: ");
            num1.A = ReadInt();

            Console.Write("Input b1: ");
            num1.B = ReadInt();

            Console.Write("Input a2: ");
            num2.A = ReadInt();

            Console.Write("Input b2: ");
            num2.B = ReadInt();

            Console.WriteLine("\n" + "Choose operation.");
            Console.WriteLine("1.Sum.");
            Console.WriteLine("2.Minus.");
            Console.WriteLine("3.Multi.");
            Console.WriteLine("4.Divide.");

            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Fractals sum = num1.Sum(num2);
                    Console.Clear();
                    Console.WriteLine($"Answer is: {sum.GetAnswer():F2}");
                    break;

                case ConsoleKey.D2:
                    Fractals minus = num1.Minus(num2);
                    Console.Clear();
                    Console.WriteLine($"Answer is: {minus.GetAnswer():F2}");
                    break;

                case ConsoleKey.D3:
                    Fractals multi = num1.Multi(num2);
                    Console.Clear();
                    Console.WriteLine($"Answer is: {multi.GetAnswer():F2}");
                    break;

                case ConsoleKey.D4:
                    Fractals divide = num1.Divide(num2);
                    Console.Clear();
                    Console.WriteLine($"Answer is: {divide.GetAnswer():F2}");
                    break;

                default:
                    break;
            }

            Pause();
        }
        static void Main(string[] args)
        {
            bool close = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Input task number. (Press ESC to exit)" + "\n");
                Console.WriteLine("1.Complex.");
                Console.WriteLine("2.Odd number sum.");
                Console.WriteLine("3.Fractals");
                ConsoleKeyInfo a = Console.ReadKey();

                switch (a.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Task1();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Task2();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Task3();
                        break;

                    case ConsoleKey.Escape:
                        close = true;
                        break;

                    default:
                        break;
                }
            } while (!close);
        }
    }
}
