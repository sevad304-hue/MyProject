using System;

namespace LearningApp
{
    public class Task4
    {
        public static void AverageValue()
        {
            Console.Clear();
            Console.WriteLine("Введите два числа");
            Console.Write("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());
            double sr = (a + b) / 2;
            Console.WriteLine($"Среднее значение:{sr}");

        }
    }
}