using System;
using AreaCalculator.Models;
using AreaCalculator.Services.Validation;

namespace AreaCalculator.Services.Calculation
{
    /// <summary>
    /// Класс реализующий вычисление площади круга.
    /// </summary>
    internal class CircleAreaCalculator : IAreaCalculator
    {
        private readonly Circle _circle;

        public CircleAreaCalculator(Circle circle)
        {
            _circle = circle;
        }

        public double? Calculate()
        {
            var result = new CircleValidator().Validate(_circle);

            return result.IsValid 
                ? Math.PI * Math.Pow(_circle.Radius, 2) 
                : default(double?);
        }
    }
}