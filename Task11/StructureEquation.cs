using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    struct StructureEquation
    {
        double b;
        double k;        

        public StructureEquation(double b, double k)
        {
            this.b = b;
            this.k = k;
        }
        public double Root()
        {
            return -b / k;
        }
    }
}
