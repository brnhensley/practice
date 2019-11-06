using System;

class HotelCost
{
    static void Main()
    {
        Console.WriteLine("What season are you coming?");
        bool summer = Console.ReadLine().ToLower() == "summer" ? true : false;

        Console.WriteLine("Weekend or weeknight?");
        bool weekend = Console.ReadLine().ToLower() == "weekend" ? true : false;

        if (summer && weekend)
        {
            Console.WriteLine("That is gonna be hella expensive.");
        }
        else if (summer || weekend)
        {
            Console.WriteLine("Could be worse!");
        }
        else
        {
            Console.WriteLine("It's cheap AF but you gotta sleep on my cousin's couch.");
        }
    }
}