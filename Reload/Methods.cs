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

        public static int SumNumbersOne(int x)
        {
            if (x < 0) x = -x;
            string xStr = Convert.ToString(x);
            if (xStr.Length == 1)
            {
                return x=Convert.ToInt32(xStr);
            }
            var y = xStr[0]-'0';
            x = Convert.ToInt32(y);
            xStr= xStr.Substring(1);
            int xq = Convert.ToInt32(xStr);
            return x+SumNumbersOne(xq);
        }

         public static int SumNumbersTwo(int x)
         {
             if (x < 0) x = -x;
             int y = 0;
             string xStr = Convert.ToString(x);
             for (int i = 0; i < xStr.Length; i++)
             {
                 y =y+Convert.ToInt32(xStr[i])-'0';
             }
             return y;
         }

         public static bool PasswordVerification(string password)
         {
            bool MinSymphol() => password.Length >= 8;
            bool NumbersPassword() 
            { 
                foreach (char x in password) 
                {
                    if (char.IsDigit(x))
                        return true;
                } 
                return false;
             }
            bool LetterPassword() 
            { 
                foreach (char x in password) 
                {
                    if (char.IsLetter(x))
                        return true;
                } 
                return false;
            }
            bool itog = MinSymphol() && NumbersPassword() && LetterPassword();
            Console.WriteLine(itog);
            return itog;
         }

         public enum TypeBuy
         {
             Hard,
             Soft,
             Ad,
         }

         public static void Purchase(TypeBuy type)
         {
             switch (type)
             {
                 case TypeBuy.Hard:
                     Console.Write($"Тяжелый продукт");
                     break;
                 case TypeBuy.Soft:
                     Console.Write($"Безалкогольный продукт");
                     break;
                 case TypeBuy.Ad:
                     Console.Write($"Рекламный продукт");
                     break;
             }
             
         }
            
        



    }
    
    
}