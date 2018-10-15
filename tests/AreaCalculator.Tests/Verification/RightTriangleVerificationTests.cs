using System.Collections;
using AreaCalculator.Models;
using AreaCalculator.Services.Verification;
using NUnit.Framework;

namespace AreaCalculator.Tests.Verification
{
    [TestFixture]
    public class RightTriangleVerificationTests
    {
        private class RightTriangleVerificationTestCaseData
        {
            public static IEnumerable TestCase
            {
                get
                {
                    yield return new TestCaseData(new Triangle { SideA = 3F, SideB = 4F, SideC = 5F }).Returns(true);
                    yield return new TestCaseData(new Triangle { SideA = 3.3333, SideB = 4.4444, SideC = 5.5555 }).Returns(true);
                    yield return new TestCaseData(new Triangle { SideA = 4F, SideB = 5F, SideC = 6F }).Returns(false);
                    yield return new TestCaseData(new Triangle {SideA = 4.44, SideB = 5.55, SideC = 6.66 }).Returns(false);
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
         TestCaseSource(typeof(RightTriangleVerificationTestCaseData),
             nameof(RightTriangleVerificationTestCaseData.TestCase))]
        public bool? RightTriangleVerificationTest(Triangle triangle)
        {
            return new RightTriangleVerifier(triangle).IsRightTriangle();
        }
    }
}