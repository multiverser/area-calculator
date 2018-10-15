using System;
using System.Collections;
using AreaCalculator.Helpers;
using NUnit.Framework;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class HelpersTests
    {
        private class MathConvertTestCaseData
        {
            public static IEnumerable TestCaseForToDegreesConversion
            {
                get
                {
                    yield return new TestCaseData(Math.PI).Returns(180F);
                    yield return new TestCaseData(Math.PI / 2F).Returns(90F);
                }
            }

            public static IEnumerable TestCaseForToRadiansConversion
            {
                get
                {
                    yield return new TestCaseData(90F).Returns(Math.PI / 2F);
                    yield return new TestCaseData(180F).Returns(Math.PI);
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

        [Test, TestCaseSource(typeof(MathConvertTestCaseData), 
             nameof(MathConvertTestCaseData.TestCaseForToDegreesConversion))]
        public double MathConvertRadiansToDegreesTest(double radians)
        {
            return MathConvert.ToDegrees(radians);
        }

        [Test, TestCaseSource(typeof(MathConvertTestCaseData), 
             nameof(MathConvertTestCaseData.TestCaseForToRadiansConversion))]
        public double MathConvertDegreesToRadiansTest(double degrees)
        {
            return MathConvert.ToRadians(degrees);
        }
    }
}