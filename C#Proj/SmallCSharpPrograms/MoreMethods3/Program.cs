using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input a number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            NumberChanger.Division(userNum, out int answer);
            Console.WriteLine(userNum + " / 2 = " + answer);

            Console.WriteLine("Please input a sentence");
            string userString = Console.ReadLine();
            NumberChanger.OutputTest(userString, out string outputString);
            Console.WriteLine("UpperCase: " + outputString);

            Console.WriteLine("Please input a number to divide");
            int userSecondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a number to divide that number by");
            int dividingNum = Convert.ToInt32(Console.ReadLine());
            NumberChanger.Division(userSecondNum, dividingNum, out int outputNum);
            Console.WriteLine(userSecondNum + " / " + dividingNum + " = " + outputNum);

            Console.ReadLine();
        }
    }
}
