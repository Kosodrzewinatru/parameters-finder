using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametersFinder
{
    class Member
    {
        public double a, b, c, fitness;

        public Member Clone()
        {
            Member temp = new Member();
            temp.a = a;
            temp.b = b;
            temp.c = c;
            temp.fitness = fitness;

            return temp;
        }
    }
}
