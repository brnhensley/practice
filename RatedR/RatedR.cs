using System;

class RatedR
{
    static void Main()
    {
        Console.WriteLine("This movie has tons of naked butts, what is your age?");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine(age >= 17 ? "Come on in and check out these butts." : "Go back to kindergarden, creep.");
    }
}