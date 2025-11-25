using System;

namespace LearningApp
{
    public class Task3
    {
        public static void Cost()
        {
            Console.Clear();
            Console.WriteLine("Расчет товара");
            Console.Write("Введите цену:");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите процент скидки:");
            int discount = Convert.ToInt32(Console.ReadLine());
            double sum = (double)(price * x * (1-discount / 100.00));
            Console.WriteLine($"К оплате:{sum}");

        }
    }
}