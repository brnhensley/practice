using System;
using System.Collections.Generic;

class PhoneBook
{
    public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>() { {"kevin", "666"}, {"barbi", "34134135"} };

    static void Main()
    {
        Console.WriteLine("MAIN MENU");
        Console.WriteLine("To add a contact press [Y], to look up a contact press [F], to Quit press [X]");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y")
        {
            AddContact();
            Main();
        }
        else if (answer == "f")
        {
            GetContact();
            Main();
        }
        else
        {
            Console.WriteLine("See ya later");
        }

    }

    static void AddContact()
    {
        Console.WriteLine("Enter a name");
        string name = Console.ReadLine().ToLower();
        Console.WriteLine("Enter a phone number");
        string number = Console.ReadLine().ToLower();
    }

    static void GetContact()
    {
        Console.WriteLine("Who do you want to find?");
        Console.WriteLine(phoneNumbers[Console.ReadLine().ToLower()]);
    }
}