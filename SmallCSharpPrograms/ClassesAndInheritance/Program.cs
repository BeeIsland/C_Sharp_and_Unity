using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student"};
            employee.SayName();
            Console.ReadLine();
        }
    }
}
