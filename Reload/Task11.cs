using System;
using  System.Collections.Generic;
namespace LearningApp
{
    public class Task11
    {
        public static void Repeat()
        {
            string[] list = { "sword", "potion", "potion", "gem", "sword", "sword" };
            var checklist = new Dictionary<string, int>();
            foreach (var i in list)
            {
                if (checklist.ContainsKey(i))
                {
                    checklist[i]++;
                }
                else
                {
                    checklist[i] = 1;
                }
               
            }
            
            foreach (var i in checklist)
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
        }
    }
}