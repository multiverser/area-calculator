using System;
using AreaCalculator.Models;
using AreaCalculator.Services.Validation;
using FluentValidation.TestHelper;
using NUnit.Framework;

namespace AreaCalculator.Tests.Validation
{
    [TestFixture]
    public class CircleValidationTests
    {
        private CircleValidator _validator;

        [SetUp]
        public void SetUp()
        {
            _validator = new CircleValidator();
        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void CircleWithZeroRadiusValidationTest()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Radius, 
                new Circle { Radius = 0F })
                .WithErrorMessage("Значение радиуса круга должно быть больше нуля.");
        }

        [Test]
        public void CircleWithNegativeRadiusValidationTest()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Radius, 
                new Circle { Radius = -1F })
                .WithErrorMessage("Значение радиуса круга должно быть больше нуля.");
        }

        [Test]
        public void CircleWithExcessRadiusValidationTest()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Radius, 
                new Circle { Radius = double.MaxValue })
                .WithErrorMessage($"Значение радиуса круга не должно превышать { Math.Sqrt(double.MaxValue) / Math.PI }");
        }

        [Test]
        public void CircleWithCorrectRadiusValidationTest()
        {
            _validator.ShouldNotHaveValidationErrorFor(c => c.Radius, 
                new Circle { Radius = 1F });
        }
    }
}