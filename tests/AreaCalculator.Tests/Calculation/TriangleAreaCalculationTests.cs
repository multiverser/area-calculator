using System.Collections;
using AreaCalculator.Models;
using AreaCalculator.Services.Calculation;
using NUnit.Framework;

namespace AreaCalculator.Tests.Calculation
{
    [TestFixture]
    public class TriangleAreaCalculationTests
    {
        private class TriangleAreaCalculationTestCaseData
        {
            public static IEnumerable TestCase
            {
                get
                {
                    yield return new TestCaseData(new Triangle { SideA = 3F, SideB = 4F, SideC = 5F }).Returns(6F);
                    yield return new TestCaseData(new Triangle()).Returns(null);
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
         TestCaseSource(typeof(TriangleAreaCalculationTestCaseData),
             nameof(TriangleAreaCalculationTestCaseData.TestCase))]
        public double? TriangleAreaCalculationTest(Triangle triangle)
        {
            return new TriangleAreaCalculator(triangle).Calculate();
        }
    }
}