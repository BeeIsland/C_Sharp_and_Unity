using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    internal class mathFunctions
    {
        public static int Square(int number)
        {
            return number * number;
        }

        public static int Cube(int number)
        {
            return number * number * number;
        }

        public static int Factorial(int number)
        {
            int total = 1;
            for (int i = 0; i < number; i++)
            {
                total *= number-i;
            }
            return total;
        }
    }
}
