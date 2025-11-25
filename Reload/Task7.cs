using System;

namespace LearningApp
{
    public class Task7
    {
        public static void Text()
        {
            string numberText = "42";
            int number = Convert.ToInt32(numberText);
            number = number + 10;
            numberText = Convert.ToString(number);
            Console.WriteLine(numberText);
        }
    }
}


