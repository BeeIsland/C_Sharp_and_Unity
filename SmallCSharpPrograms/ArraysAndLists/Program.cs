using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] stringArray = { "Hello", "There", "Nice", "To", "Meet", "You"};
        Console.WriteLine("Pick a number from 0-5");
        int chosenNum = Convert.ToInt32(Console.ReadLine());

        if (chosenNum > 5 || chosenNum < 0)
        {
            Console.WriteLine("Pick a number between 0 and 5 next time!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(stringArray[chosenNum]);
            Console.ReadLine();
        }

        int[] intArray = { 3, 2304, 4506, 203, 10, 210 };
        Console.WriteLine("Pick a number from 0-5");
        chosenNum = Convert.ToInt32(Console.ReadLine());

        if (chosenNum > 5 || chosenNum < 0)
        {
            Console.WriteLine("Pick a number between 0 and 5 next time!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(intArray[chosenNum]);
            Console.ReadLine();
        }

        List<string> stringList = new List<string> { "Great", "To", "Meet", "You" };
        Console.WriteLine("\nPick a number from 0-3 this time");
        chosenNum = Convert.ToInt32(Console.ReadLine());

        if (chosenNum > 5 || chosenNum < 0)
        {
            Console.WriteLine("Pick a number between 0 and 3 next time!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(stringList[chosenNum]);
            Console.ReadLine();
        }
    }
}
