using System;

class StartsWithZ
{
    static void Main()
    {
        Console.WriteLine("What's your name, buddy?");
        string name = Console.ReadLine();
        Console.WriteLine(name.StartsWith("Z") ? "Well hot shit, your name starts with 'Z'." : $"Well cold shit, you name starts with '{name[0]}'.");
    }
}