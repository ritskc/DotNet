using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.ExtensionMethod
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char c = inputString[0];

                inputString = inputString.Remove(0, 1);
                return char.ToUpper(c) + inputString;
            }
            return inputString;
        }
    }
}
