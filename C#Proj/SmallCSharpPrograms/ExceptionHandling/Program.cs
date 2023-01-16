using System;
using System.Collections.Generic;
using System.Text;

 class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Pick a number to divide all available numbers by.");
            int dividingNum = Convert.ToInt32(Console.ReadLine());

            List<int> numList = new List<int>() { 2,45,7,3,8,87,234,6,9,75,34,1,445565,78,5,12,100,56,2343};

            foreach (int num in numList)
            {
                Console.WriteLine(num/dividingNum);
            }

        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.\n" + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.\n" + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
        
    }
}

