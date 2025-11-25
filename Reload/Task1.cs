using System;

namespace LearningApp
{
    class Task1

    {
        public static void Calculate()
        {
            Console.Clear();
            Console.Write("Введите текущий час:");
            byte time = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            if (time >= 23)
            {
                Console.WriteLine("Некорректные данные");
            }
            else if (time == 0)
            {
                Console.WriteLine("Сейчас полночь");
            }
            else
            {
                int x = 24 - time;
                Console.WriteLine($"Осталось до полуночи:  {x}");
            }


        }
    }
}