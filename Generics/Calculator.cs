using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Generics
{
    public class Calculator<T>
    {
        public static bool AreEqual(T value1, T Value2)
        {
            return value1.Equals(Value2);
        }
    }
}
