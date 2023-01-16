using System;


internal class Program
{
    static void Main()
    {
        //This program gets the income information of 2 people and stores them as ints
        Console.WriteLine("Anonymous Income Comparison Program\n\nPerson 1:");
        Console.WriteLine("What is your hourly rate?");
        int P1hrlyRate = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many hours do you work a week?");
        int P1hrsPerWeek = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nPerson 2:");
        Console.WriteLine("What is your hourly rate?");
        int P2hrlyRate = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many hours do you work a week?");
        int P2hrsPerWeek = Convert.ToInt32(Console.ReadLine());

        int P1Annual = P1hrlyRate * P1hrsPerWeek * 52;
        int P2Annual = P2hrlyRate * P2hrsPerWeek * 52;

        Console.WriteLine("\nAnnual salary of Person 1: $" + P1Annual.ToString());
        Console.WriteLine("Annual salary of Person 2: $" + P2Annual.ToString());

        bool oneMoreThanTwo;
        if (P1Annual > P2Annual) { oneMoreThanTwo = true; }
        else { oneMoreThanTwo = false; }

        Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
        Console.WriteLine(oneMoreThanTwo);
        Console.ReadLine();

    }
}

