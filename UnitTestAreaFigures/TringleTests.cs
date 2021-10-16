using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaFigure;

namespace UnitTestAreaFigures
{
    [TestClass]
    public class TringleTests
    {
        [TestMethod]
        public void TestAreaTringleByThreeSides1()
        {
            //Expectation
            double A = 50;
            double B = 70;
            double C = 80;
            double expected = 1732.0508075688772;

            Tringle tringle = new Tringle(A, B, C);
            double actual = tringle.Area();

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

            Tringle tringle = new Tringle(A, B, C);
            double actual = tringle.Area();

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

            Tringle tringle = new Tringle(A, B, C);
            double actual = tringle.Area();

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

            Tringle tringle = new Tringle(A, B, C);
            bool actual = tringle.CheckRectangular();

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

            Tringle tringle = new Tringle(A, B, C);
            bool actual = tringle.CheckRectangular();

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

            Tringle tringle = new Tringle(A, B, C);
            bool actual = tringle.CheckRectangular();

            Assert.AreEqual(expected, actual);
        }
    }
}
