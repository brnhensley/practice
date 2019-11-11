using System;
using System.Collections.Generic;

class PhoneBook
{
    public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>() { { "kevin", "666" }, { "barbi", "34134135" } };

    static void Main()
    {
        Console.WriteLine("MAIN MENU");
        Console.WriteLine("To add a contact press [Y], to look up a contact press [F], to Quit press [X]");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y")
        {
            AddContact();
        }
        else if (answer == "f")
        {
            GetContact();
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
        if (phoneNumbers.ContainsKey(name))
        {
            Console.WriteLine($"The name {name} is already in your phone book. Choose another name? [Y] or [N]");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                AddContact();
                return;
            }
            else
            {
                Main();
                return;
            }
        }
        Console.WriteLine("Enter a phone number");
        string number = Console.ReadLine().ToLower();
        phoneNumbers.Add(name, number);
        Main();
    }

    static void GetContact()
    {
        Console.WriteLine("Who do you want to find?");
        string name = Console.ReadLine().ToLower();
        if (phoneNumbers.ContainsKey(name))
        {
            Console.WriteLine($"{name}'s phone number is {phoneNumbers[name]}");
        }
        else
        {
            Console.WriteLine($"{name} is not in your phone book dude");
        }
        Main();
    }
}