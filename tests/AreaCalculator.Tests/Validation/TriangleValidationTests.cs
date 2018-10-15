using AreaCalculator.Models;
using AreaCalculator.Services.Validation;
using FluentValidation.TestHelper;
using NUnit.Framework;

namespace AreaCalculator.Tests.Validation
{
    [TestFixture]
    public class TriangleValidationTests
    {
        private TriangleValidator _validator;

        [SetUp]
        public void SetUp()
        {
            _validator = new TriangleValidator();
        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void TriangleWithZeroSideAValidationTest()
        {
            _validator.ShouldHaveValidationErrorFor(t => t.SideA, 
                    new Triangle { SideA = 0F, SideB = 4F, SideC = 5F })
                .WithErrorMessage("Сторона A должна быть больше нуля.");
        }

        [Test]
        public void TriangleWithZeroSideBValidationTest()
        {
            _validator.ShouldHaveValidationErrorFor(t => t.SideB,
                    new Triangle { SideA = 3F, SideB = 0F, SideC = 5F })
                .WithErrorMessage("Сторона B должна быть больше нуля.");
        }

        [Test]
        public void TriangleWithZeroSideCValidationTest()
        {
            _validator.ShouldHaveValidationErrorFor(t => t.SideC,
                    new Triangle { SideA = 3F, SideB = 4F, SideC = 0F })
                .WithErrorMessage("Сторона C должна быть больше нуля.");
        }

        [Test]
        public void TriangleWithExcessSideAValidationTest()
        {
            _validator.ShouldHaveValidationErrorFor(t => t.SideA,
                    new Triangle { SideA = 10F, SideB = 4F, SideC = 5F })
                .WithErrorMessage("Сторона А должна быть меньше суммы двух других сторон.");
        }

        [Test]
        public void TriangleWithExcessSideBValidationTest()
        {
            _validator.ShouldHaveValidationErrorFor(t => t.SideB,
                    new Triangle { SideA = 3F, SideB = 9F, SideC = 5F })
                .WithErrorMessage("Сторона B должна быть меньше суммы двух других сторон.");
        }

        [Test]
        public void TriangleWithExcessSideCValidationTest()
        {
            _validator.ShouldHaveValidationErrorFor(t => t.SideC,
                    new Triangle { SideA = 3F, SideB = 4F, SideC = 8F })
                .WithErrorMessage("Сторона C должна быть меньше суммы двух других сторон.");
        }

        [Test]
        public void TriangleHypotenuseGreaterThanSideAValidationTest()
        {
            _validator.ShouldHaveValidationErrorFor(t => t.SideC,
                    new Triangle { SideA = 3F, SideB = 4F, SideC = 2F })
                .WithErrorMessage("Сторона C(гипотенуза) должна быть больше строны A.");
        }

        [Test]
        public void TriangleHypotenuseGreaterThanSideBValidationTest()
        {
            _validator.ShouldHaveValidationErrorFor(t => t.SideC,
                    new Triangle { SideA = 3F, SideB = 4F, SideC = 3.5 })
                .WithErrorMessage("Сторона C(гипотенуза) должна быть больше строны B.");
        }

        [Test]
        public void TriangleWithCorrectSidesValidationTest()
        {
            Assert.IsTrue(_validator.Validate(new Triangle(3F, 4F, 5F)).IsValid);
        }
    }
}