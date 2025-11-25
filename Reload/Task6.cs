using System;

namespace LearningApp
{
    public class Task6
    {
        public static void Convert()
        {
            int a = 5;
            int b = 12;
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}