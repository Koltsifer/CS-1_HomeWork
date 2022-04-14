//2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i, m, h;
            Console.WriteLine("Body Mass Index (BMI)");

            Console.Write("Weight(Kg): ");
            m = double.Parse(Console.ReadLine());
            Console.Write("Height(Cm): ");
            h = Convert.ToDouble(Console.ReadLine()) / 100;

            i = m / Math.Pow(h, 2);

            Console.WriteLine($"BMI: {i:F2}");
            Console.ReadKey();
        }
    }
}
