using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    public class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.ReadLine();
            Console.WriteLine("Give me a number");
            int addNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In {0} hours it will be {1}", addNum, now.AddHours(addNum));
            Console.ReadLine();
        }
    }
}
