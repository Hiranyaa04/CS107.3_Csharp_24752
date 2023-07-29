using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Q2
{
    internal class FindValues
    {
        public double findArea(double r)
        { 
            double Area = Math.PI * r * r;
            return Area;
        }

        public double findCircumference(double r)
        {
            double circ = Math.PI * r * 2;
            return circ;
        }
    }
}
