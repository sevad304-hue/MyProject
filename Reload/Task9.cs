using System;

namespace LearningApp
{
    public class Task9
    {
        public static void Filter()
        {
            int k = 0;
            int[] value = { 10, 2, 34, 4, 55, 6, 7 };
            for (int i = 0; i < value.Length; i++)
            {
                
                if (value[i] > 10 && value[i] % 2 == 0)
                {
                    k++;
                    Console.WriteLine($"{i}: {value[i]}");
                    //Console.WriteLine($"{k}");
                }
            }
            int j = 0;
            int[] result = new int[k];
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] > 10 && value[i] % 2 == 0)
                {
                    result[j] = value[i];
                    //Console.WriteLine($"{j}: {result[j]}"); 
                    if (j < k) 
                    { 
                        j++; 
                    }
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"{i}: {result[i]}");
            }
            
        }
    }
}
