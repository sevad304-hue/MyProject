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
            double max = x[0];
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

        public static void Raise(ref double x)
        {
            x++;
            
        }

        public static void MaxMin(ref double max, ref double min)
        { 
            if (max < min)
            {
                double x = 0;
                x = max;
                max = min;
                min = x;
            }
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
        }

        public static void Median(params double[] nums)
        {
           Console.WriteLine(nums.Length);
            if (nums.Length % 2 == 0)
            {
                var median = (nums[( nums.Length-1) / 2]+nums[( nums.Length+1) / 2])/2;
                Console.WriteLine($"Медиана чисел равна - {median}");
            }
            else
            {
                var median = nums[nums.Length/2];
                Console.WriteLine($"Медиана чисел равна - {median}");
            }

         

        }
        
        

    }
    
    
}