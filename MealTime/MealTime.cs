using System;

class MealTime
{
    static void Main()
    {
        string[] meals = { "breakfast", "lunch", "dinner", "shit" };

        foreach (string meal in meals)
        {
            Console.WriteLine("What did you eat for " + meal + "?");
            string yourBreakfast = Console.ReadLine();
            Console.WriteLine($"You had {yourBreakfast} for {meal}. loser");
        }
    }
}