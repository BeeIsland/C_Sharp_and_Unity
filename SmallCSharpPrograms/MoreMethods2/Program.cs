using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            InvisMath numbers = new InvisMath();
            numbers.NumDisplay(10, 20);
            numbers.NumDisplay(num1: 30, num2: 40);
            Console.ReadLine();
        }
    }
}
