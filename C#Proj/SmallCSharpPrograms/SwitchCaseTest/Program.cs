using System;

class Program
{
    static void Main()
    {

        //Number guessing

        int pInput;
        string rawInput;
        do
        {
            pInput = 0;
            Console.WriteLine("Please input a number from one to five or type 'EXIT' to move on");
            rawInput = Console.ReadLine();

            if (rawInput.ToUpper() == "EXIT")
            {
                break;
            }

            try
            {
                Convert.ToInt32(rawInput);

            }
            catch
            {
                Console.WriteLine("Please input a number next time (ex. 5, 2 ,3)\n");
                pInput = 364572;
            }

            if (pInput != 364572)
            {
                pInput = Convert.ToInt32(rawInput);
            }
            else if (pInput == 1)
            {
                break;
            }

            switch (pInput)
            {
                case 1:
                    Console.WriteLine("This is a small number");
                    Console.ReadLine();
                    break;
                case 364572:
                    break;
                default:
                    if (pInput > 5)
                    {
                        Console.WriteLine("The number is too big");
                    }
                    else if (pInput < 1)
                    {
                        Console.WriteLine("The number is too small");
                    }
                    else
                    {
                        Console.WriteLine("I've got nothing to say to people who didn't choose one");
                    }
                    break;
            }
        }
        while (pInput != 1);

        //Number adding

        string response = "";
        int total = 0;
        int addNum;

        while (response.ToUpper() != "EXIT")
        {
            Console.WriteLine("Please a number to add to the total or type 'EXIT' to end the program");
            response = Console.ReadLine();

            if (response.ToUpper() == "EXIT")
            {
                break;
            }

            addNum = Convert.ToInt32(response);
            total += addNum;

            Console.WriteLine("New total: " + total.ToString());
        }
    }
}

