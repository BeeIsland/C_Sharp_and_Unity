using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee<T> : Person
    {
        public int EmployeeID { get; set; }
        public List<T> Things { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public static bool operator ==(Employee<T> Employee1, Employee<T> Employee2)
        {
            if (Employee1.EmployeeID == Employee2.EmployeeID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee<T> Employee1, Employee<T> Employee2)
        {
            if (Employee1.EmployeeID == Employee2.EmployeeID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
