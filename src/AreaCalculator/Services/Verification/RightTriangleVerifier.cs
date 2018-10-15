using System;
using AreaCalculator.Helpers;
using AreaCalculator.Models;
using AreaCalculator.Services.Validation;

namespace AreaCalculator.Services.Verification
{
    /// <summary>
    /// Класс реализующий логику проверки треугольника на наличие угла в 90 градусов.
    /// </summary>
    internal class RightTriangleVerifier : IRightTriangleVerifier
    {
        private readonly Triangle _triangle;

        public RightTriangleVerifier(Triangle triangle)
        {
            _triangle = triangle;
        }

        public bool? IsRightTriangle()
        {
            var result = new TriangleValidator().Validate(_triangle);

            if (!result.IsValid)
                return default(bool?);

            var hypOppositeAngle = MathConvert.ToDegrees(
                Math.Acos(
                    MathConvert.ToRadians(
                        (Math.Pow(_triangle.SideA, 2) + Math.Pow(_triangle.SideB, 2) - Math.Pow(_triangle.SideC, 2))
                        / 2F * _triangle.SideA * _triangle.SideB
                    )
                )
            );

            return Math.Abs(hypOppositeAngle - 90F) <= MathConvert.Precision;
        }
    }
}