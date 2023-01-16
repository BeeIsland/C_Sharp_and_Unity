using System;
using System.Collections.Generic;
using System.Text;

namespace MoreMethods
{
    internal class Program
    {
        static void Main()
        {
            MathOperation test = new MathOperation();
            Console.WriteLine(test.Operate(10));
            Console.WriteLine(test.Operate(10m));
            Console.WriteLine(test.Operate("10"));
            Console.ReadLine();
        }
    }
}
