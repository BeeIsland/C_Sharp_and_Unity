using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { EmployeeID = 1, FirstName = "Bob", LastName = "Sherman" });
            employees.Add(new Employee() { EmployeeID = 2, FirstName = "Joe", LastName = "Sherman" });
            employees.Add(new Employee() { EmployeeID = 3, FirstName = "Billy", LastName = "Smeez" });
            employees.Add(new Employee() { EmployeeID = 4, FirstName = "Joe", LastName = "Dillain" });
            employees.Add(new Employee() { EmployeeID = 5, FirstName = "Hedge", LastName = "Dillain" });
            employees.Add(new Employee() { EmployeeID = 6, FirstName = "John", LastName = "Smith" });
            employees.Add(new Employee() { EmployeeID = 7, FirstName = "Sally", LastName = "Smith" });
            employees.Add(new Employee() { EmployeeID = 8, FirstName = "Milty", LastName = "Smith" });
            employees.Add(new Employee() { EmployeeID = 9, FirstName = "Molly", LastName = "Sue" });
            employees.Add(new Employee() { EmployeeID = 10, FirstName = "Joe", LastName = "Jean" });

            List<Employee> guysNamedJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    guysNamedJoe.Add(employee);
                }
            }
            List<Employee> lGuysNamedJoe = employees.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> lastHalf = employees.Where(x => x.EmployeeID > 5).ToList();

            foreach (Employee employee in guysNamedJoe)
            {
                Console.WriteLine(employee.LastName);
            }

            Console.WriteLine();

            foreach (Employee employee in lGuysNamedJoe)
            {
                Console.WriteLine(employee.LastName);
            }

            Console.WriteLine();

            foreach (Employee employee in lastHalf)
            {
                Console.WriteLine(employee.EmployeeID);
            }

            Console.ReadLine();


        }
    }
}
