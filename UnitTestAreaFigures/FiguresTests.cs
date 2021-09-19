using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaFigure;

namespace UnitTestAreaFigures
{
    [TestClass]
    public class FiguresTests
    {        
        [TestMethod]
        public void TestAreaCircleByRadius1()
        {
            //Expectation
            double radius = 5;
            double expected = Math.PI * Math.Pow(radius, 2);
            //если сравнивать с заданным в ручную double,
            //выдает ошибку, хотя значения совпадают,
            //если честно не знаю как правильно сравнивать double
            
            double actual = Figures.AreaCircleByRadius(radius);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAreaCircleByRadius2()
        {
            //Expectation
            double radius = 3;
            double expected = Math.PI * Math.Pow(radius, 2);

            double actual = Figures.AreaCircleByRadius(radius);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAreaCircleByRadius3()
        {
            //Expectation
            double radius = 6.2;
            double expected = Math.PI * Math.Pow(radius, 2);

            double actual = Figures.AreaCircleByRadius(radius);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAreaTringleByThreeSides1()
        {
            //Expectation
            double A = 50;
            double B = 70;
            double C = 80;
            double expected = 1732.0508075688772;

            double actual = Figures.AreaTringleByThreeSides(A, B, C);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAreaTringleByThreeSides2()
        {
            //Expectation
            double A = 40;
            double B = 70;
            double C = 90;
            double expected = 1341.640786499874;

            double actual = Figures.AreaTringleByThreeSides(A, B, C);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAreaTringleByThreeSides3()
        {
            //Expectation
            double A = 3.5;
            double B = 8.4;
            double C = 9.6;
            double expected = 14.512962955578713;

            double actual = Figures.AreaTringleByThreeSides(A, B, C);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckRectangularTringle1()
        {
            //Expectation
            double A = 50;
            double B = 70;
            double C = 80;
            bool expected = false;

            bool actual = Figures.CheckRectangularTringle(A, B, C);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckRectangularTringle2()
        {
            //Expectation
            double A = 90; 
            double B = 70;
            double C = 40;
            bool expected = true;

            bool actual = Figures.CheckRectangularTringle(A, B, C);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckRectangularTringle3()
        {
            //Expectation
            double A = 3.5;
            double B = 9.6;
            double C = 8.4;
            bool expected = true;

            bool actual = Figures.CheckRectangularTringle(A, B, C);

            Assert.AreEqual(expected, actual);
        }
    }
}
