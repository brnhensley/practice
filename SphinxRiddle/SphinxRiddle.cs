using System;
using System.Collections.Generic;

static class SphinxRiddle
{
    static List<int> riddles = new List<int> { 0, 0, 0 };
    static List<string> order = new List<string> { "FIRST", "SECOND", "THIRD" };
    static int index = 0;

    static void Main()
    {
        RiddleOrder();
        Console.WriteLine("RIDDLE OF THE SPHINX:");
        ChooseRiddle();
    }

    static void RiddleOrder()
    {
        bool exists = false;

        for (int i = 0; i < 3; i++)
        {
            while (riddles[i] == 0)
            {
                int random = new Random().Next(1, 4);

                foreach (int riddle in riddles)
                {
                    if (riddle == random)
                    {
                        exists = true;
                    }
                }

                if (!exists)
                {
                    riddles[i] = random;
                }
                else
                {
                    exists = false;
                }
            }
        }
    }

    static void RiddleOne()
    {
        Console.WriteLine("How do you spell hard water with three letters?");
        string answer = Console.ReadLine().ToLower();

        if (answer == "ice")
        {
            Console.WriteLine("Correct!");
            index++;
            ChooseRiddle();
        }
        else
        {
            Loser();
        }
    }

    static void RiddleTwo()
    {
        Console.WriteLine("When is a door not a door?");
        string answer = Console.ReadLine().ToLower();
        if (answer == "when it is ajar")
        {
            Console.WriteLine("Correct!");
            index++;
            ChooseRiddle();
        }
        else
        {
            Loser();
        }
    }

    static void RiddleThree()
    {
        Console.WriteLine("What is best in life?");
        string answer = Console.ReadLine().ToLower();
        if (answer == "to crush your enemies, see them driven before you, and to hear the lamentation of their women")
        {
            Console.WriteLine("Correct!");
            index++;
            ChooseRiddle();
        }
        else
        {
            Loser();
        }
    }

    static void ChooseRiddle()
    {
        if (index < 3)
        {
            Console.WriteLine($"{order[index]} QUESTION!");

            if (riddles[index] == 1)
            {
                RiddleOne();
            }
            else if (riddles[index] == 2)
            {
                RiddleTwo();
            }
            else if (riddles[index] == 3)
            {
                RiddleThree();
            }
        }
        else
        {
            Winner();
        }
    }

    static void Winner()
    {
        Console.WriteLine("YOU FUCKING RULE! YOU ARE THE RIDDLEMASTER!");
    }

    static void Loser()
    {
        Console.WriteLine("WRONG! THE SPHINX ATE YOU! LOOOOOOOOOOSERER!");
    }
}
