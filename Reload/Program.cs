using System;


namespace Reload
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            /*Console.Clear(); 
            var result = Methods.Sum(12, -123); 
            Console.WriteLine(result);
            var result1 = Methods.Sum(23 , -54); 
            Console.WriteLine(result1); 
            var result2 = Methods.Sum(-800, 1225.4); 
            Console.WriteLine(result2); 
            var result3 = Methods.Discount(1000, 45); 
            Console.WriteLine(result3); 
            var result4 = Methods.Discount(500 , 35); 
            Console.WriteLine(result4); 
            var result5 = Methods.Discount(6000, 101);
            Console.WriteLine(result5);*/
            var result6 = Methods.Discount(6000, 25);
            Console.WriteLine(result6);
            Methods.Age(18);
            double[] x = {-10, -8, -3, -12, -5, -34};
            Methods.Elements(x);
            var result7 = Methods.MaxElements(x);
            Console.WriteLine(result7);
            double y = 13;
            Methods.Raise(ref y);
            Console.WriteLine(y);
            Methods.Raise(ref y);
            Console.WriteLine(y);
            double max = 21;
            double min = 23;
            Methods.MaxMin(ref max, ref min);
            Methods.Median(12, 13, 14, 15, 55, 12, 54, 34, 24, 53, 34,8);
        }
    }
}