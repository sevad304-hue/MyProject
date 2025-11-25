using System;

namespace LearningApp
{
    public class Task5
    {
        public static void Lengt()
        { 
            Console.Clear();
            Console.WriteLine("Введите предложение:");
            string text = Convert.ToString(Console.ReadLine());
            
            int z=text.Length;
            Console.WriteLine($"Символов в предложение :{z}");

        }
    }
}