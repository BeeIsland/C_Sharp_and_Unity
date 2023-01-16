using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods3
{
    static class NumberChanger
    {
        public static void Division(int num1, out int answer)
        {
            answer = num1 / 2;
        }

        public static void OutputTest(string input, out string output)
        {
            output = input.ToUpper();
        }

        public static void Division(int num1, int dividingNum, out int answer)
        {
            answer = num1 / dividingNum;
        }
    }
}
