using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Generics
{
    public class GenericClient
    {
        public void Get()
        {
            Calculator<int>.AreEqual(1, 1);
        }
    }
}
