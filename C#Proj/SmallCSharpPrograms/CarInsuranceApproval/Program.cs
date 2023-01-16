using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Car Insurance Check");
        Console.WriteLine("\nWhat is your age?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Have you ever had a DUI? Please enter 1 for YES, and 0 for NO");
        bool hadDUI = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("How many speeding tickets do you have");
        int numSpeedingTickets = Convert.ToInt32(Console.ReadLine());

        bool qualifies = false;
        if (numSpeedingTickets <= 3 && age > 15 && hadDUI == false) { qualifies = true; }

        Console.WriteLine("\nResult of qualification test below:\n" + qualifies);
        Console.ReadLine();
    }
}
