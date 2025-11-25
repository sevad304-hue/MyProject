using System;

namespace LearningApp
{

    class Task2
    {
        public static void Temperatur()
        {
            Console.Clear();
            Console.Write("Введите температуру в градусах Цельсиях:");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            double F = C * 1.8 + 32;
            Console.WriteLine($"Температура по фаренгейту равна {F}");
        }
    }
}