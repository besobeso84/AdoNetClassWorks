using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork4
{
    class classImplementInterface : exampleInterface
    {
        public int methodN1()
        {
            return 12;
        }

        public int methodN2(int n1)
        {
            return n1 + 10;
        }

        public double methodN3(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
