using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Sharp
{
    class Dot
    {
        double x=0;
        double y =0;
        public Dot(double xx, double yy)
        {
            x = xx;
            y = yy;
        }
        public double X
        {
            get => x;
            set => x = value;
        }
        public double Y
        {
            get => y;
            set => y = value;
        }
    }
}
