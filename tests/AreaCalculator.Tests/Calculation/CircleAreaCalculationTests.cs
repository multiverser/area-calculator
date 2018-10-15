using System.Collections;
using AreaCalculator.Models;
using AreaCalculator.Services.Calculation;
using NUnit.Framework;

namespace AreaCalculator.Tests.Calculation
{
    [TestFixture]
    public class CircleAreaCalculationTests
    {
        private class CircleAreaCalculationTestCaseData
        {
            public static IEnumerable TestCase
            {
                get
                {
                    yield return new TestCaseData(new Circle { Radius = 1 }).Returns(3.1415926535897931);
                    yield return new TestCaseData(new Circle { Radius = 2 }).Returns(12.5663706143591724);
                    yield return new TestCaseData(new Circle { Radius = 1.5 }).Returns(7.068583470577034475);
                }
            }
        }

        [SetUp]
        public void SetUp()
        {

        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test,
         TestCaseSource(typeof(CircleAreaCalculationTestCaseData), 
             nameof(CircleAreaCalculationTestCaseData.TestCase))]
        public double? CircleAreaCalculationTest(Circle circle)
        {
            return new CircleAreaCalculator(circle).Calculate();
        } 
    }
}