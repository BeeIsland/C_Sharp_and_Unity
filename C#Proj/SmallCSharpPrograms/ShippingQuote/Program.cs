using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("How heavy is the package in pounds");
        int pckgWeight = Convert.ToInt32(Console.ReadLine());
        if (pckgWeight > 50)
        { 
            Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day");
        }
        else
        {
            Console.WriteLine("What is the width of the package?");
            int pckgWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the package?");
            int pckgHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length of the package?");
            int pckgLength = Convert.ToInt32(Console.ReadLine());
            if (pckgWidth + pckgHeight + pckgLength > 50) 
            {
                Console.WriteLine("Package is too big to be shipped via Package Express. Have a good day");
            }
            else
            {
                int quote = (pckgLength * pckgHeight * pckgWidth * pckgWeight)/100;
                Console.WriteLine("Your quote is : $" + quote.ToString() + ".00\nThank You!");
            }
        }
        Console.ReadLine();
    }
}

