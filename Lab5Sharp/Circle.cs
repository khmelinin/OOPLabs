using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Sharp
{
    class Circle:Figure
    {
        double r;
        public Circle(double rr)
        {
            r = rr;
        }
        public override double S()
        {
            return Math.PI*r*r;
        }
        public override double P()
        {
            return Math.PI*2*r;
        }
    }
}
