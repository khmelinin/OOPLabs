using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Sharp
{
    class Trapez:Figure
    {
        Dot[] dot;
        //private double[,] v;

        double ab, bc, cd, da,h;
        /*
        public Trapez(double[,]vv)
        {
            
            v = vv;
            ab = Math.Sqrt((v[1, 0] - v[0, 0]) * (v[1, 0] - v[0, 0]) + (v[1, 1] - v[0, 1]) * (v[1, 1] - v[0, 1]));
            bc = Math.Sqrt((v[2, 0] - v[1, 0]) * (v[2, 0] - v[1, 0]) + (v[2, 1] - v[1, 1]) * (v[2, 1] - v[1, 1]));
            cd = Math.Sqrt((v[3, 0] - v[2, 0]) * (v[3, 0] - v[2, 0]) + (v[3, 1] - v[2, 1]) * (v[3, 1] - v[2, 1]));
            da = Math.Sqrt((v[0, 0] - v[3, 0]) * (v[0, 0] - v[3, 0]) + (v[0, 1] - v[3, 1]) * (v[0, 1] - v[3, 1]));
            h = v[1, 1] - v[3, 1];

        }
        */
        public Trapez(Dot[]dot1)
        {
            dot = dot1;
            ab = Math.Sqrt((dot[1].X - dot[0].X) * (dot[1].X - dot[0].X) + (dot[1].Y - dot[0].Y) * (dot[1].Y - dot[0].Y));
            bc = Math.Sqrt((dot[2].X - dot[1].X) * (dot[2].X - dot[1].X) + (dot[1].Y - dot[1].Y) * (dot[2].Y - dot[1].Y));
            cd = Math.Sqrt((dot[3].X - dot[2].X) * (dot[3].X - dot[2].X) + (dot[3].Y - dot[2].Y) * (dot[3].Y - dot[2].Y));
            da = Math.Sqrt((dot[0].X - dot[3].X) * (dot[0].X - dot[3].X) + (dot[0].Y - dot[3].Y) * (dot[0].Y - dot[3].Y));
           
            h = dot[0].Y - dot[3].Y;

        }
        public override double S()
        {
            return (ab + cd) / 2 * h;
        }
        public override double P()
        {
            return ab+bc+cd+da;
        }
    }
}
