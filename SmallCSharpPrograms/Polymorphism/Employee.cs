using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : Person, IQuittable
    {
        public int EmployeeID { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            FirstName = "Not";
            LastName = "Applicable";
            SayName();
        }

        public static bool operator== (Employee Employee1, Employee Employee2) 
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

        public static bool operator!= (Employee Employee1, Employee Employee2)
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
