using NUnit.Framework;
using FigureLib;

namespace FigureLibUnitTest
{
    public class CircleTests
    {
        [Test]
        public void Test1()
        {
            Circle circle = new Circle("Circle", 5);

            Assert.AreEqual("Circle", circle.FigureName);
        }
        [Test]
        public void Test2()
        {
            Circle circle = new Circle("Circle", 5);

            Assert.AreEqual(5, circle.Radius);
        }
        [Test]
        public void Test3()
        {
            Circle circle = new Circle("Circle", 5);

            Assert.AreEqual(78.5, circle.CalculateSquare());
        }
    }

}
