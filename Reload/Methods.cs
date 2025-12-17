using System;

namespace Reload
{
    public class Methods
    {
        public static double Sum(double x, double y)=> x + y;

        public static double Discount(double cost, double discount)
        {
            if (cost < 0)
            {
                
                throw new ArgumentException("Не правильная цена");
                
            }
            if (discount < -1 && discount > 101)
            {
            
                throw new ArgumentException("Не правильная скидка");
            }
            var pay = cost-cost * (discount / 100);
            return pay;
        }

        public static void Age(int age)
        {
            Console.WriteLine(age > 17 ? $"{age} Совершеннолетний" : $"{age} Несовершеннолетний"); // ? : (условие ? значение_если_верно : значение_если_ложно) 
        }

        public static void Elements( double[] x)
        {
            foreach (var i in x)
            {
                Console.Write($"{i} ");
            }
        }
        
        public static double MaxElements( double[] x)
        {
            double max = 0;
            foreach (var i in x)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.Write($"\nМаксимальный элемент:");
            return max;
        }
        
    }
    
    
}