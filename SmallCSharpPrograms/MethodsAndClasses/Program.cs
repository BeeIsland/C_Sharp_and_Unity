using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number to do math on.");
            string rawInput = Console.ReadLine();
            int numToMath = Convert.ToInt32(rawInput);
            Console.WriteLine("Square of number = " + mathFunctions.Square(numToMath));
            Console.WriteLine("Cube of number = " + mathFunctions.Cube(numToMath));
            Console.WriteLine("Factorial of number = " + mathFunctions.Factorial(numToMath));

            Console.ReadLine();
        }
    }
}
