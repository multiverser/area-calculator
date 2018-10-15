using System;
using AreaCalculator.Models;
using AreaCalculator.Services.Validation;

namespace AreaCalculator.Services.Calculation
{
    /// <summary>
    /// Класс вычислителя площади треугольника.
    /// </summary>
    public class TriangleAreaCalculator : IAreaCalculator
    {
        private readonly Triangle _triangle;

        public TriangleAreaCalculator(Triangle triangle)
        {
            _triangle = triangle;
        }

        public double? Calculate()
        {
            var result = new TriangleValidator().Validate(_triangle);

            if (!result.IsValid)
                return default(double?);

            var halfPerimeter = (_triangle.SideA + _triangle.SideB + _triangle.SideC) / 2F;

            return Math.Sqrt(halfPerimeter 
                             * (halfPerimeter - _triangle.SideA) 
                             * (halfPerimeter - _triangle.SideB) 
                             * (halfPerimeter - _triangle.SideC));
        }
    }
}