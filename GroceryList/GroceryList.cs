using System;
using System.Collections.Generic;
using System.Linq;

class GroceryList
{
    public static Dictionary<string, int> groceryList = new Dictionary<string, int>() {
            { "eggs", 2 },
            { "milk", 5 },
            { "bread", 3 },
            { "bananas", 2 },
            { "cereal", 5 },
            { "rice", 1 },
            { "yogurt", 4 }
        };

    static void Main()
    {
        int total = 0;

        foreach (KeyValuePair<string, int> grocery in groceryList)
        {
            total += grocery.Value;
        }

        Console.WriteLine("Your receipt:");

        for (int i = 0; i < groceryList.Count; i++)
        {
            Console.WriteLine(groceryList.ElementAt(i).Key);
        }
        Console.WriteLine($"Your total is ${total}.");
    }
}