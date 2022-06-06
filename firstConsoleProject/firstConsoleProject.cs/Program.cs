using System;
class Program
{
    static void Main()
    {

        ///Take in and display a string
        //Console.WriteLine("What is your name?");
        //string userName = Console.ReadLine();
        //Console.WriteLine("Hello there, \"" + name + "\"!");
        //Console.ReadLine();

        ///Cast a string to a number
        //Console.WriteLine("What is you favorite number?");
        //int favoriteNumber = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Your favorite number plus 5 is: " + (favoriteNumber + 5).ToString());
        //Console.ReadLine();

        ///Examples of all the data types
        bool isStudying = true;
        byte hoursWorked = 4;
        sbyte currentTemperature = -23;
        char questionMark = '\u2103';

        Console.WriteLine(questionMark);
        Console.ReadLine();
        
        decimal moneyInBank = 1000m;

        double heightInCentimeters = 211.3020309;

        float secondsLeft = 2.62f;

        short marioXPos = -3940;

        string myName = "Cameron";

        bool isRaining = true;
        string rainingStatus = Convert.ToString(isRaining);



    }
}
