using System;

namespace HomeWork2
{
    internal class Program
    {
        static void Task1()
        {
            //1.Написать метод, возвращающий минимальное из трёх чисел.

            int min, a, b, c;
            Console.WriteLine("Minimum of 3");

            Console.Write("Input a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Input c: ");
            c = int.Parse(Console.ReadLine());

            min = a;
            if (b < a) min = b; 
            else 
            { 
                if (c < a) min = c; 
            }

            Console.WriteLine($"Min: {min}");
            Console.ReadKey();
        }
        static void Task2()
        {
            //2.Написать метод подсчета количества цифр числа.

            int count = 0;
            Console.WriteLine("Input number");

            int a = int.Parse(Console.ReadLine());

            while (a > 0) { a = a / 10; count++; }

            Console.WriteLine($"Amount is {count}");
            Console.ReadKey();
        }
        static void Task3()
        {
            //3.С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.

            int count = 0;
            int a, b;
            Console.WriteLine("Amount of odd numbers (0 to stop)");
            do
            {
                Console.Write("Input number: ");
                a = int.Parse(Console.ReadLine());
                b = a % 2;
                if (b == 1)
                {
                    count++;
                }
            } while (a != 0);
            Console.WriteLine("Amount of odd numbers is: " + count);
            Console.ReadKey();
        }
        static void Task4()
        {
            //4.Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль.На выходе истина, если прошел авторизацию, и ложь, если не прошел
            //(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше
            //или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.

           Console.WriteLine("Login and password.");
            int count = 3;
            bool acces = false;
            do
            {
                Console.Write("Input login: ");
                string a = Console.ReadLine();
                Console.Write("Input password: ");
                string b = Console.ReadLine();

                if (a == "root" && b == "GeekBrains")
                {
                    acces = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Login and password.");
                    count--;
                    Console.WriteLine(count + ((count == 1) ? " attempt" : " attempts") + " left");
                }
            } 
            while ((acces == false) && (count > 0));

            if (acces == true)
            {
                Console.Clear();
                Console.WriteLine("Access granted!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Too many attempts");
            }
            Console.ReadKey();

        }
        static void Task5()
        {
            //5.
            //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            Console.WriteLine("BMI");
            int i;

            Console.Write("Input height: ");
            double h = double.Parse(Console.ReadLine()) / 100;
            Console.Write("Input weight: ");
            double w = double.Parse(Console.ReadLine());

            double BMI = w / Math.Pow(h, 2);
            Console.WriteLine($"Yor BMI is: {BMI:F2}");
            Console.ReadKey();

            if (BMI < 16) i = 0;
            else
            {
                if (BMI < 18.6) i = 1;
                else
                {
                    if (BMI < 26) i = 2;
                    else
                    {
                        if (BMI < 31) i = 3;
                        else
                        {
                            if (BMI < 36) i = 4;
                            else
                            {
                                if (BMI < 41) i = 5;
                                else i = 6;
                            }
                        }
                    }
                }
            }
            double n = (22 * Math.Pow(h, 2)) - w;
            switch (i)
            {
                case 0:
                    Console.WriteLine("Significant deficiency in body mass!");
                    Console.WriteLine($"To gain normal weight you must gain {n:F2} kg");
                    break;
                case 1:
                    Console.WriteLine("Deficiency in body mass.");
                    Console.WriteLine($"To gain normal weight you must gain {n:F2} kg");
                    break;
                case 2:
                    Console.WriteLine("Normal body mass.");
                    break;
                case 3:
                    Console.WriteLine("Excess weight.");
                    Console.WriteLine($"To gain normal weight you must gain {n:F2} kg");
                    break;
                case 4:
                    Console.WriteLine("Obesity of the first degree!");
                    Console.WriteLine($"To gain normal weight you must gain {n:F2} kg");
                    break;
                case 5:
                    Console.WriteLine("Obesity of the second degree!");
                    Console.WriteLine($"To gain normal weight you must gain {n:F2} kg");
                    break;
                case 6:
                    Console.WriteLine("Obesity of the third degree!");
                    Console.WriteLine($"To gain normal weight you must gain {n:F2} kg");
                    break;


            }
            Console.ReadKey();

        }
        static void Task6()
        {
            //6. * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр.
            //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            int main = 1, pmain, count = 0;
            DateTime start = DateTime.Now;
            while (main != 1000000000)
            {
                int d = 0;
                pmain = main;
                while (pmain > 0)
                {
                    int c = pmain % 10;
                    d = d + c;
                    pmain = pmain / 10;
                }
                if (main % d == 0) count++;
                main++;
                Console.WriteLine(main);
            }
            DateTime finish = DateTime.Now;
            TimeSpan result = finish - start;

            Console.WriteLine("\n"+"Amount of good numbers is: " + count);
            Console.WriteLine("It took: "+ $"{result.Seconds}" + " seconds.");
            Console.ReadKey();

        }
        static void Task7()
        {
            //7.
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            Console.WriteLine("Input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int c = a;
                a = b;
                b = c;
            }
            long sum = 0;
            sum = Loop(a, b, sum);
            Console.WriteLine("\n" + "Sum is: " + sum);
            Console.ReadKey();

        }
        static long Loop(int a, int b, long sum)
        {
            if (a <= b)
            {
                Console.Write(a + " ");
                sum += a;
                a++;
                return Loop(a, b, sum);
            }
            return sum;
        }
        static void Bonus()
        {
            //7.
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            Console.WriteLine("Input number: ");
            long main = long.Parse(Console.ReadLine());
            BonusLoop(main);
            Console.ReadKey();

        }
        static string BonusLoop(long main)
        {
            string q = "", w = "", e = "", r = "", t = "", y = "", u = "", i = "", o = "", p = "";
            while (main != 0)
            {
                long a = main % 10;
                switch (a)//вводишь любую последовательность чисел, и этот код их упорядочивает
                {
                    case 0:
                        q = q + $"{a}";
                        break;
                    case 1:
                        w = w + $"{a}";
                        break;
                    case 2:
                        e = e + $"{a}";
                        break;
                    case 3:
                        r = r + $"{a}";
                        break;
                    case 4:
                        t = t + $"{a}";
                        break;
                    case 5:
                        y = y + $"{a}";
                        break;
                    case 6:
                        u = u + $"{a}";
                        break;
                    case 7:
                        i = i + $"{a}";
                        break;
                    case 8:
                        o = o + $"{a}";
                        break;
                    case 9:
                        p = p + $"{a}";
                        break;

                    default:
                        break;
                }
                main = main / 10;
            }
            string result = q + w + e + r + t + y + u + i + o + p; // единственное ограничение Int493 ой
            Console.WriteLine(result);
            return result;
        }
        static void Main()
        {
            bool close = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Input Task number (1-7)   Press Esc to shut down" + "\n");
                Console.WriteLine("1.Minimum of 3 numbers.");
                Console.WriteLine("2.Amount of numbers.");
                Console.WriteLine("3.Amount of odd numbers.");
                Console.WriteLine("4.Login and password.");
                Console.WriteLine("5.BMI calculator.");
                Console.WriteLine("6.Amount of good numbers.");
                Console.WriteLine("7.Loop.");
                Console.WriteLine("8.Bonus.");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
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
                    case ConsoleKey.D4:
                        Console.Clear();
                        Task4();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Task5();
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Task6();
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        Task7();
                        break;
                    case ConsoleKey.D8:
                        Console.Clear();
                        Bonus();
                        break;
                    case ConsoleKey.Escape:
                        close = true;
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }
            while (close == false);
        }
    }
}
// ебать, до мен ядошло что это, нихуя себе, через свитч блять сортировку сделать//я вчера тебе по дису говорил что ты возможно подумаешь что я ебанутый и это можно сделать проще
// можно, сортировка очень часто делается методом попарной смены соседних, дальше будут задания с сортировкой)), горжусь собой что быстро довольно таки до такого додумался
// забавно, но это делается куда производительнее и проще,дается массив, все элементы перемешаны, это могут быть и не по одной цифре, а
// многозначные числа, сравниваются два соседних,
// если левое меньше не трогаем, если больше меняем, илем к след паре кирилл, посмотри, я вспонил о чём ты
//в общем я молодец, ))нет, ты невнимательный и проделал зря кучу работы)), впрочем как всегда эх ты, ладно покеп