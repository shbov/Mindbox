using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLib;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1,2,3)]
        [DataRow(1,5,4)]
        public void CheckIfTriangleIsNotRectangle(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
            Assert.IsFalse(triangle.IsRectangular);
        }

        [TestMethod]
        [DataRow(3,4,5)]
        public void CheckIfTriangleIsRectangle(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
            Assert.IsTrue(triangle.IsRectangular);
        }
        
        [TestMethod]
        public void CheckTriangleSquare()
        {
            Triangle triangle = new Triangle(3,4,5);
            Assert.IsTrue(Math.Abs(triangle.Square() - 6) < 10e-6);
        }
        
        [TestMethod]
        public void CheckCircleSquare()
        {
            Circle triangle = new Circle(2);
            Assert.IsTrue(Math.Abs(triangle.Square() - 12.5663706) < 10e-6);
        }
    }
}