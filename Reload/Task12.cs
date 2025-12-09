using System;
using  System.Collections.Generic;

namespace LearningApp
{
    public class Task12
    {
        public static void Estimation()
        {
            int[] marks = { 5, 4, 3, 5, 2, 4, 5, 3 };
            var max = marks[0];
            var min = marks[0];
            var sum = 0f;
            var checklist = new Dictionary<int, int>();
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }

                if (marks[i] < min)
                {
                    min = marks[i];
                }
                sum=sum+marks[i];
                if (checklist.ContainsKey(marks[i]))
                {
                    checklist[marks[i]]++;
                }
                else
                {
                    checklist.Add(marks[i], 1);
                }
            }
           
            var average = sum / marks.Length;
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            foreach (var i in checklist)
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
                
            }
        }
    }
}