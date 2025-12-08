using System;


namespace LearningApp
{
    public class Task10
    {
        public static void Normalization()
        {
            float max=0;
            float[] stats = { 2.5f, 7.3f, 3.1f, 10f };
            for (int i = 0; i < stats.Length; i++)
            {
                for (int j = i + 1; j < stats.Length; j++)
                {
                    if (stats[j] > stats[i])
                    {
                        max = stats[j];
                        
                    }
                    
                }
            }
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