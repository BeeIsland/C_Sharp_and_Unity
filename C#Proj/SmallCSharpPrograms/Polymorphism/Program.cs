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
            Employee employee1 = new Employee() { EmployeeID = 1};
            Employee employee2 = new Employee() { EmployeeID = 2};
            if (employee1 == employee2)
            {
                Console.WriteLine("The two employees are the same");
            }
            else if (employee1 != employee2)
            {
                Console.WriteLine("The two employees are not the same");
            }
            Console.ReadLine();
        }
    }
}
