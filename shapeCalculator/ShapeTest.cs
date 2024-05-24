using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace shapeCalculator
{
    [TestFixture]
    public class ShapeTest
    {
        [TestCase(12d, 75.3982)]
        [TestCase(5d, 31.4159)]
        [TestCase(30d, 188.4956)]
        public void CircleCircumferenceTest(double input, double expected)
        {
            Circle circle = new Circle();
            circle.radius = input;
            double expectedValue = expected;
            double actualValue = circle.getCircumference();
            Assert.That(expectedValue, Is.EqualTo(actualValue).Within(0.01).Percent);
        }

        [Test]
        public void CircleAreaTest()
        {
            Circle circle = new Circle();
            circle.radius = 10;
            double expectedValue = 314.159d;
            double actualValue = circle.getArea();
            Assert.That(expectedValue, Is.EqualTo(actualValue).Within(0.01).Percent);
        }

        [Test]
        public void RectangleCircumferenceTest()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.a = 5;
            rectangle.b = 10;
            double expectedValue = 30;
            double actualValue = rectangle.getCircumference();
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void RectangleAreaTest()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.a = 5;
            rectangle.b = 10;
            double expectedValue = 50;
            double actualValue = rectangle.getArea();
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void TriangleCircumferenceTest()
        {
            Triangle triangle = new Triangle();
            triangle.a = 5;
            triangle.b = 6;
            triangle.c = 7;
            double expectedValue = 18;
            double actualValue = triangle.getCircumference();
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }

        [Test]
        public void TriangleAreaTest()
        {
            Triangle triangle = new Triangle();
            triangle.a = 5;
            triangle.b = 6;
            triangle.c = 7;
            double expectedValue = 14.697;
            double actualValue = triangle.getArea();
            Assert.That(expectedValue, Is.EqualTo(actualValue).Within(0.01).Percent);
        }

        [Test]
        public void TriangleInvalidAreaTest()
        {
            Triangle triangle = new Triangle();
            triangle.a = 5;
            triangle.b = 5;
            triangle.c = 12;
            double expectedValue = double.NaN;
            double actualValue = triangle.getArea();
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }
    }
}
