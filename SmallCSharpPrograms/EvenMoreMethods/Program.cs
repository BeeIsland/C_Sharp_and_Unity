using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenMoreMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathTime mathTime = new MathTime();
            Console.WriteLine("Input a number to multiply");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you want to multiply by a number other than 10, please input it now\nOtherwise, leave it blank and press enter");
            string rawNum = Console.ReadLine();

            if (rawNum == "")
            {
                Console.WriteLine(mathTime.Multiply(num1));
            }
            else
            {
                Console.WriteLine(mathTime.Multiply(num1, Convert.ToInt32(rawNum)));
            }
            Console.ReadLine();
        }
    }
}
