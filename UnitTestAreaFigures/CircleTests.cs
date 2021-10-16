using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaFigure;

namespace UnitTestAreaFigures
{
    [TestClass]
    public class CircleTests
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

            Circle circle = new Circle(radius);
            double actual = circle.Area();
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAreaCircleByRadius2()
        {
            //Expectation
            double radius = 3;
            double expected = Math.PI * Math.Pow(radius, 2);

            Circle circle = new Circle(radius);
            double actual = circle.Area();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAreaCircleByRadius3()
        {
            //Expectation
            double radius = 6.2;
            double expected = Math.PI * Math.Pow(radius, 2);

            Circle circle = new Circle(radius);
            double actual = circle.Area();

            Assert.AreEqual(expected, actual);
        }
    }
}
