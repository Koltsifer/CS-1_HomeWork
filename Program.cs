using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork4
{
    internal class Program
    {
        static void Task1()
        {
            //1.Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
            //Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
            //В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

            int[] array = new int[20];
            Random random = new Random();
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10000, 10000);
            }
            foreach (int element in array)
            {
                Console.Write("|" + element);
            }
            Console.Write("|");

            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] % 3 == 0 | array[i++] % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("\n" + "Count = " + count);
            Console.ReadKey();
        }

        static void Task2()
        {
            //2.Реализуйте задачу 1 в виде статического класса StaticClass;
            //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            //б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
            //в)*Добавьте обработку ситуации отсутствия файла на диске.

            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10000, 10000);
            }

            StaticClass.ClassTask1(array);

            int[] a = StaticClass.Read("array.txt");

            foreach (var element in a)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }

        static class StaticClass
        {
            public static void ClassTask1(int[] array)
            {
                int count = 0;
                foreach (int element in array)
                {
                    Console.Write("|" + element);
                }
                Console.Write("|");

                for (int i = 0; i < array.Length; i += 2)
                {
                    if (array[i] % 3 == 0 | array[i++] % 3 == 0)
                    {
                        count++;
                    }
                }

                Console.WriteLine("\n" + "Count = " + count);
            }

            public static int[] Read(string Pass)
            {
                int[] readed = new int[20];
                int i = 0;
                try
                {
                    StreamReader sr = null;
                    sr = new StreamReader(Pass);
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        readed[i++] = int.Parse(line);
                    }
                    sr.Close();
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found.");
                }

                return readed;
            }
        }

        static void Task3()
        {
            //3.
            //а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и
            //заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива,
            //метод Inverse, возвращающий новый массив с измененными знаками у всех
            //элементов массива(старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива на определённое число,
            //свойство MaxCount, возвращающее количество максимальных элементов.
            //б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
            //в) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)

            int size = 10; //Default settings
            int first = 2; //Default settings
            int step = 2; //Default settings

            #region input
            //bool flag;
            //do
            //{
            //    flag = false;
            //    try
            //    {
            //        Console.Write("input Size(1 | 10000): ");
            //        size = int.Parse(Console.ReadLine());

            //        Console.Write("input first number(0 | 10000): ");
            //        first = int.Parse(Console.ReadLine());

            //        Console.Write("input step of numbers(0 | 10000): ");
            //        step = int.Parse(Console.ReadLine());

            //        if (size < 1 || size > 10000 || first < 0 || first > 10000 || step < 0 || step > 10000)
            //        {
            //            throw new ArgumentOutOfRangeException();
            //        }
            //    }
            //    catch (Exception exc)
            //    {
            //        flag = true;
            //        Console.WriteLine("\n{0}\nНажмите любую кнопку для продолжения.", exc.Message);
            //        Console.ReadKey();
            //        Console.Clear();
            //    }
            //} while (flag);
            #endregion

            DArray array = new DArray(size, first, step); //создание массива

            Console.WriteLine("Sum: " + array.Sum); //сумма всех элементов массива

            int[] rev = array.Inverse();//возвращает новый инвертированный массив
            foreach (int element in rev) { Console.Write(element + " "); }

            array.Mult(2);//умножает каждый элемент массива на аргумент
            Console.WriteLine();
            foreach (int element in array.get) { Console.Write(element + " "); }

            Console.WriteLine("\nMax: " + array.MaxCount);//возвращает максимальное число в массиве

            MyLib.MyArray arraylib = new MyLib.MyArray(20, 2, 2);

            arraylib.Multi(2);//умножение через библиотеку
            Console.WriteLine();
            foreach (int element in arraylib.get) { Console.Write($"{element} "); };

            #region хуйня не смотреть
            int[] ebanutiyarray = { 7, 7, 2, 4, 8, 0, 8, 3, 9, 4, 5, 8, 6, 1, 9 };
            Array.Sort(ebanutiyarray);
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < ebanutiyarray.Length; i++)
            {
                dic.Add(i, ebanutiyarray[i]);
            }
            int v0 = 0, v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0, v6 = 0, v7 = 0, v8 = 0, v9 = 0;
            foreach (int element in dic.Values)
            {
                switch (element)
                {
                    case 0:
                        v0++;
                        break;

                    case 1:
                        v1++;
                        break;

                    case 2:
                        v2++;
                        break;

                    case 3:
                        v3++;
                        break;

                    case 4:
                        v4++;
                        break;

                    case 5:
                        v5++;
                        break;

                    case 6:
                        v6++;
                        break;

                    case 7:
                        v7++;
                        break;

                    case 8:
                        v8++;
                        break;

                    case 9:
                        v9++;
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine($"\n0:{v0} 1:{v1} 2:{v2} 3:{v3} 4:{v4} 5:{v5} 6:{v6} 7:{v7} 8:{v8} 9:{v9}");
            #endregion

            Console.ReadKey();
        }

        class DArray
        {
            int[] x_;

            public DArray(int size, int first, int step)
            {
                x_ = new int[size];
                x_[0] = first;
                for (int i = 1; i < x_.Length; i++)
                {
                    x_[i] = x_[i - 1] + step;
                }
            }

            public int[] get { get { return x_; } }

            public int Sum
            {
                get
                {
                    int sum = 0;
                    foreach (int element in x_)
                    {
                        sum += element;
                    }
                    return sum;
                }
            }

            public int MaxCount
            {
                get
                {
                    int max = 0;
                    for (int i = 0; i < x_.Length; i++)
                    {
                        if (x_[i] > max)
                            max = x_[i];
                    }
                    return max;
                }
            }

            public int[] Inverse()
            {
                int[] a = new int[x_.Length];
                Array.Copy(x_, a, x_.Length);
                Array.Reverse(a);
                return a;
            }

            public int[] Mult(int count)
            {
                for (int i = 0; i < x_.Length; i++)
                {
                    x_[i] = x_[i] * count;
                }
                return x_;
            }
        }

        static void Task4()
        {
            //4.Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account, содержащую Login и Password.

            StreamReader sr = new StreamReader("Pass.txt");
            int count = 0;
            string line;
            string[] pass = new string[2];
            while ((line = sr.ReadLine()) != null)
            {
                pass[count++] = line;
            }
            sr.Close();

            Account a = new Account(pass[0], pass[1]);

            count = 3;
            bool flag = true;
            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();

                if (login == pass[0] && password == pass[1])
                {
                    Console.WriteLine("Вход успешен.");
                    flag = false;
                }
                else
                {
                    count--;
                    Console.WriteLine("Неверно! У вас остал" + (count == 1 ? "ась " : "ось ") + count + " попыт" + (count == 2 ? "ки" : count == 0 ? "ок" : "ка") + "\n");
                }
                if (count == 0)
                {
                    flag = false;
                    Console.WriteLine("Попытки закончились.");
                }

            } while (flag);

            Console.ReadKey();
        }

        struct Account
        {
            string login_;
            string password_;

            public Account(string login, string password)
            {
                login_ = login;
                password_ = password;
            }
            public string Login { get { return login_; } }
            public string Password { get { return password_; } }
        }

        static void Task5()
        {
            //5.
            //а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.
            //Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство,
            //возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод,
            //возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
            //*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
            //* *в) Обработать возможные исключительные ситуации при работе с файлами.

            Array2d.Array2d array = new Array2d.Array2d(3, 2);

            array.DrawArray();

            Console.WriteLine("\nSum: " + array.Sum());

            int max = 5;
            Console.WriteLine("Sum(min:{1}): {0}", array.Sum(max), max);
            Console.WriteLine("Minimal is: " + array.Minimal);
            Console.WriteLine("Maximum is: " + array.Maximum);
            array.NumberMax(array.Maximum);
            array.Save();

            Console.WriteLine();
            foreach (var item in array.Load)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static void Main()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Укажите номер задачи");

                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case (ConsoleKey.D1):
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

                    case ConsoleKey.Escape:
                        flag = false;
                        break;

                    default:
                        break;
                }
            } while (flag);
        }
    }
}
