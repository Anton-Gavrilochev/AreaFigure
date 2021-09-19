using System;

namespace AreaFigure
{
    public static class Figures
    {
        public static double AreaCircleByRadius(double radius) {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double AreaTringleByThreeSides(double a, double b, double c){
            double p = (a + b + c) / 2; 
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public static bool CheckRectangularTringle(double A, double B, double C){
            double[] sourceData = { A, B, C };
            Array.Sort(sourceData);
            A = sourceData[0];
            B = sourceData[1];
            C = sourceData[2];
            if (Math.Pow(C, 2) > Math.Pow(A, 2) + Math.Pow(B, 2))
                return true;
            else
                return false;
        }
    }
}
