using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    delegate int withNumber(int p);
    class workingWithNumber
    {
        static int N = 10;
        public static int workN1(int p)
        {
            N += p;
            return N;
        }
        public static int workN2(int p)
        {
            N *= p;
            return N;
        }
        public static int workN3(int p)
        {
            N -= p;
            return N;
        }
        public static int returnN()
        {
            return N;
        }
    }
}
