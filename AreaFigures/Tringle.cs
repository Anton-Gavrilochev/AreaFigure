using System;

namespace AreaFigure
{
    public class Tringle : Figure
    {
        double a, b, c;

        public Tringle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool CheckRectangular()
        {
            double[] sourceData = { a, b, c };
            Array.Sort(sourceData);
            a = sourceData[0];
            b = sourceData[1];
            c = sourceData[2];
            return Math.Pow(c, 2) > Math.Pow(a, 2) + Math.Pow(b, 2);
        }
    }
}
