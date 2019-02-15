using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametersFinder
{
    class Range
    {
        public double beginning, end;

        public Range Clone()
        {
            Range temp = new Range();
            temp.beginning = beginning;
            temp.end = end;

            return temp;
        }
    }
}
