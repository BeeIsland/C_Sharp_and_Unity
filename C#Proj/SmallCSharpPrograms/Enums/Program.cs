using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input a day of the week");
            string userInput = Console.ReadLine().ToLower();
            Days.DaysOfTheWeek day;

            try
            {
                day = (Days.DaysOfTheWeek)Enum.Parse(typeof(Days.DaysOfTheWeek), userInput);
                Console.WriteLine((int)day);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please input a real day of the week");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
