using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Attributes
{
    public class Calculator
    {
        [Obsolete("Use Add(List<int> numbers)")]
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Add(List<int> numbers)
        {
            return numbers.Sum(x => x);
        }
    }
}
