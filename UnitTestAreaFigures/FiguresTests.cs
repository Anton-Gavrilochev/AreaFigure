using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaFigure;
using System.Collections.Generic;

namespace UnitTestAreaFigures
{
    [TestClass]
    public class FiguresTests
    {
        [TestMethod]
        public void TestArea()
        {
            //Исходные данные
            double A = 7;
            double B = 4;
            double C = 8;
            double radius = 8;

            //Ожидаемые данные
            double[] expected = new double[] { 13.997767679169419, Math.PI * Math.Pow(radius, 2) };

            //Вывод данных
            Tringle tringle = new Tringle(A, B, C);
            Circle circle = new Circle(radius);

            List<Figure> lFigures = new List<Figure> { tringle, circle };
            double[] actual = new double[2];

            int k = 0;
            foreach(Figure figure in lFigures)
            {
                actual[k] = figure.Area();
                k++;
            }

            //Проверка
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
