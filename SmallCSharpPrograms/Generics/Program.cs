using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main()
        {
            Employee<string> employeeString = new Employee<string>() { Things = new List<string>() { "Cat", "Dog", "Frog", "Bear", "Ape", "Lizard", "Snake", "Fish" } };

            Employee<int> employeeInt = new Employee<int>() { Things = new List<int>() { 2, 10, 50, 3, 400, 78, 59, 4, 56, 59, 20, 320 } };

            foreach (int thing in employeeInt.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (string thing in employeeString.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
