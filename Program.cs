﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*

    1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.

    2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, 
в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.

    3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
Например: badc являются перестановкой abcd.

    4. *Задача ЕГЭ.
На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. В первой строке сообщается количество учеников N, 
которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:

<Фамилия> <Имя> <оценки>,
где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа, 
соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:

Иванов Петр 4 5 3
Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.

Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. 
Все программы сделать в одном решении. Для решения задач используйте неизменяемые строки (string).

*/

namespace HomeWork5
{
    internal class Program
    {
        readonly static string message = "RegExr was created by gskinner, and is proudly hosted by Media TempleEdit the Expression and Text to see matches";

        static class Message
        {
            public static void WordOutMax(string message, int count)
            {
                string result = string.Empty;
                string pattern = @"\b\w{" + count + @"}\b";
                foreach (Match m in Regex.Matches(message, pattern))
                    result += m + " ";
                Console.WriteLine(result);
            }

            public static void WordDeleteByEndChar(string message, char input)
            {
                string result = "";
                string pattern = "\\w+[^" + input + " ]\\b";
                foreach (Match m in Regex.Matches(message, pattern))
                    result += m + " ";
                Console.WriteLine(result);
                
            }

            public static void LongestWord(string message)
            {
                StringBuilder result = new StringBuilder("");
                foreach (Match m in Regex.Matches(message, @"\b[a-zA-Z]+\b"))
                    if (m.Length > result.Length || m.Length == result.Length)
                    {
                        if (m.Length == result.Length)
                            result.Append(" " + m);
                        else
                        {
                            result.Clear();
                            result.Append(m);
                        }
                    }
                Console.WriteLine(result);
            }

            public static void AnalyseRepeatingWords(string message)
            {
                Console.WriteLine("WordAnalyser\n");

                Dictionary<string, int> words = new Dictionary<string, int>()
                {
                    ["hello"] = 0,
                    ["by"] = 0,
                    ["media"] = 0,
                    ["created"] = 0,
                    ["tree"] = 0,
                    ["match"] = 0,
                    ["and"] = 0
                };

                foreach (Match m in Regex.Matches(message.ToLower(), @"\b[a-zA-Z]+\b"))
                    if (words.ContainsKey(m.Value))
                        words[m.ToString()]++;

                foreach (var pair in words)
                {
                    if (pair.Value != 0)
                        Console.WriteLine(pair.Key + " " + pair.Value);
                }
            }
        }

        static bool MessageEqual(string a, string b)
        {
            bool flag = false;
            Dictionary<char, int> x = new Dictionary<char, int>();
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                x.Add(ch, 0);
            }
            foreach (char c in a)
            {
                if (c >= 'a' && c <= 'z')
                    x[c]++;
            }
            Dictionary<char, int> y = new Dictionary<char, int>();
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                y.Add(ch, 0);
            }
            foreach (char c in b)
            {
                if (c >= 'a' && c <= 'z')
                    y[c]++;
            }
            if (x.SequenceEqual(y)) flag = true;
            return flag;
        }

        static void Main()
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
                    default:
                        Console.Clear();
                        break;
                }
            } while (key.Key != ConsoleKey.Escape);
        }

        static void Task1()
        {
            //Console.Write("Введите логин: ");
            //string a = "1cudjh23j";
            //a = Console.ReadLine();
            //bool flag = false;
            //int i = 0;
            //if (a.Length >= 2 && a.Length <= 10 && !char.IsDigit(a[0]))
            //{
            //    do
            //    {
            //        if (a[i] >= 'a' && a[i] <= 'z' || char.IsDigit(a[i]))
            //            flag = true;
            //        else { flag = false; }
            //        i++;

            //    } while (flag && i < a.Length);
            //}
            //Console.WriteLine(flag ? "Correct login" : "Wrong login");
            //Console.ReadKey();

            Console.Write("Введите логин: ");
            Regex regex = new Regex(@"^[A-Z a-z]{1}[A-Z a-z 0-9]{1,9}$");
            string x = Console.ReadLine();
            Console.WriteLine(Regex.IsMatch(x, regex.ToString())? "Correct login" : "Wrong login");
            Console.ReadKey();
        }

        static void Task2()
        {
            Message.WordOutMax(message, 3);
            Message.WordDeleteByEndChar(message, 'r');
            Message.LongestWord(message);
            Console.WriteLine();
            Message.AnalyseRepeatingWords(message);
            Console.ReadKey();
        }

        static void Task3()
        {
            //string a = "fk";
            //string b = "ap";
            //int x = 0, y = 0;
            //foreach (char c in a)
            //{
            //    x += c;
            //}

            //foreach (char c in b)
            //{
            //    y += c;
            //}

            //if(x == y && a.Length == b.Length)
            //    Console.WriteLine("Equal");
            //else Console.WriteLine("Not equal");

            string a = "vlsdjf";
            string b = "fdljsv";
            
            if(MessageEqual(a, b))
                Console.WriteLine("Equal");
            else Console.WriteLine("Not equal");

            Console.ReadKey();
        }

        static void Task4()
        {
            StreamReader sr = new StreamReader("data.txt");
            sr.Close();
            Console.WriteLine("Portable Test!");
        }
    }
}
