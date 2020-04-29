using System;

namespace Lab6Sharp
{
    
    class Expression
    {
        double a;
        double b;
        double c;
        public Expression(int aa,int bb,int cc)
        {
            a = aa;
            b = bb;
            c = cc;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double Result()
        {
            double res = 0;

            res = Dividing((8 * log10(b - 1) - c),(a * 2 + Dividing(b,c)));
               
            return res;
        }
        public double log10(double a)
        {
            double res = 0;
            try
            {
                if (a <= 0)
                throw new Exception("log10 Error");
                res = Math.Log10(a);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return res;
        }
        private double Dividing(double a, double b)
        {
            double res = 0;

            try
            {
                if (b == 0)
                    throw new Exception("dividing by zero");
                res = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return res;
        }
        public static double operator /(Expression a, double b)
        {
            double res = 0;
            
            try
            {
                if (b == 0)
                throw new Exception("dividing by zero (operator)");
                res = a.a / b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return res;
        }

    }
   
    class Program
    {
        
        static void Main(string[] args)
        {
            Expression []a = { new Expression(1,1,1), new Expression(1,2,0),new Expression(1,1,0)};

            Console.WriteLine("a[0].Result() = {0} \n",a[0].Result());
            Console.WriteLine("a[1].Result() = {0} \n",a[1].Result());
            Console.WriteLine("a[2].Result() = {0} \n",a[2].Result());

            double d = a[0] / 0;
            Console.WriteLine(d);
        }
    }
}
