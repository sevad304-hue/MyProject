using System;

namespace LearningApp
{
    public class Task8
    {
        public static void NameFamily()
        {
            Console.Clear();
            Console.Write("Введите имя:");
            string name = Console.ReadLine();
            Console.Write("Введите возраст:");
            object age = (Console.ReadLine());
            Console.WriteLine($"Привет, {name}! Тебе {age} лет.");

        }
    }
}