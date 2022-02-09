using NUnit.Framework;
using FigureLib;

namespace FigureLibUnitTest
{
    public class TriangleTests
    {
        [Test]
        public void Test1()
        {
            Triangle triangle = new Triangle("Triangle", 1, 2, 3);

            Assert.AreEqual("Triangle", triangle.FigureName);
        }

        [Test]
        public void Test2()
        {
            var triangle = new Triangle("Triangle", 1, 2, 3);

            Assert.AreEqual(1, triangle.Edge1);
            Assert.AreEqual(2, triangle.Edge2);
            Assert.AreEqual(3, triangle.Edge3);

        }
        [Test]
        public void Test3()
        {
            dynamic triangle = new Triangle("Triangle", 3, 4, 5);
            double expected = 6;

            double resultSquare = triangle.CalculateSquare();

            //Assert
            Assert.AreEqual(expected, resultSquare);
        }

        [Test]
        public void Test4()
        {
            Triangle triangle = new Triangle("Triangle", 2, 3, 4);
            Assert.IsFalse(triangle.CheckStraightness());
        }
        [Test]
        public void Test5()
        {
            Triangle triangle = new Triangle("Triangle", 5, 4, 3);
            Assert.IsTrue(triangle.CheckStraightness());
        }
    }
}