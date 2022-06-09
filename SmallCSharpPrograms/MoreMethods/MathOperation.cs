using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    internal class MathOperation
    {
        public int Operate(int number)
        {
            return number + 20;
        }

        public decimal Operate(decimal number)
        {
            return Convert.ToInt32(number * 10m);
        }

        public int Operate(string number)
        {
            int answer = Convert.ToInt32(number);
            return answer / 2;
        }
    }
}
