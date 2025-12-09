using System;
using System.Linq;

namespace LearningApp
{
    public class Task10
    {
        public static void Normalization()
        {
            float[] stats = { 2.5f, 7.3f, 3.1f, 10f };
           // float max=stats[0];
            float max = stats.Max();
           /* foreach (var t in stats)
            {
                if (max < t)
                {
                    max = t;
                }
            }*/
            Console.WriteLine($"{max}");
            float[] split = new float[stats.Length];
            for (int i = 0; i < stats.Length; i++)
            {
               split[i] = stats[i]/max;
            }
            for (int i=0; i<split.Length; i++)
            {
                Console.Write($"{i}: {split[i]} ");}
        }
        
    }
}