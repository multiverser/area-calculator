using System;
using AreaCalculator.Exceptions;
using NUnit.Framework;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class ExceptionsTests
    {
        private class UserDefinedTriangle : IFigure
        {
            #region Constructors and Destructors

            public UserDefinedTriangle()
            {

            }

            /// <summary>
            /// Конструктор геометрической фигуры типа: "Треугольник заданный двумя сторонами и углом между ними".
            /// </summary>
            /// <param name="firstSide">
            /// Сторона треугольника A.
            /// </param>
            /// <param name="secondSide">
            /// Сторона треугольника B.
            /// </param>
            /// <param name="angle">
            /// Угол между заданными сторонами в градусах.
            /// </param>
            public UserDefinedTriangle(double firstSide, double secondSide, double angle)
            {
                FirstSide = firstSide;
                SecondSide = secondSide;
                Angle = angle;
            }

            #endregion

            #region Public Properties

            public double FirstSide { get; set; }

            public double SecondSide { get; set; }

            public double Angle { get; set; }

            #endregion

            #region IFigure interface explicit implementation

            string IFigure.FigureTypeName => "Треугольник заданный двумя сторонами и углом между ними"; 

            #endregion
        }

        [SetUp]
        public void SetUp()
        {

        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void FigureNotSupportedYetExceptionTest()
        {
            IFigure triangle = new UserDefinedTriangle {FirstSide = 3F, SecondSide = 4F, Angle = 90F };

            Assert.Throws(
                Is.TypeOf<AreaCalculatorException>().And.Message.EqualTo(
                    $"Расчет площади фигуры типа '{triangle.FigureTypeName}' в данный момент не поддерживается библиотекой.")
                    .And.InnerException.TypeOf<NotSupportedException>(),
                () => triangle.GetArea());
        }
    }
}