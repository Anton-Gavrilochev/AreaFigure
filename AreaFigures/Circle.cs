using System;

namespace AreaFigure
{
    public class Circle : Figure
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
