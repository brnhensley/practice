using System;
using System.Collections.Generic;

class LeapYear
{
    static void Main()
    {

        Console.WriteLine("Enter a year to out if that bastard was a leap year or a boring normal year and how many years since has been a leap year.");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine(FindLeapYears(year) ?
            $"{year} is a leap year." :
            $"{year} is not a leap year.");

        string years = String.Join(", ", leapYearsSince(year));
        Console.WriteLine($"The all years since {year}: {years}.");
    }

    static List<int> leapYearsSince(int year)
    {
        List<int> listOfYears = new List<int> { };

        for (int i = year; i < 2019; i++)
        {
            if (FindLeapYears(i))
            {
                listOfYears.Add(i);
            }
        }
        return listOfYears;
    }

    static bool FindLeapYears(int year)
    {
        return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? true : false;
    }
}