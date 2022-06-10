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
            IQuittable employee1 = new Employee();
            employee1.Quit();
            Console.ReadLine();

            Employee employee2 = new Employee();
            employee2.Quit();
            Console.ReadLine();
        }
    }
}
