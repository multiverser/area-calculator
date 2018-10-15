using System;
using AreaCalculator.Models;
using FluentValidation;
using static FluentValidation.CascadeMode;

namespace AreaCalculator.Services.Validation
{
    /// <summary>
    /// Валидатор типа <see cref="Circle" />.
    /// </summary>
    internal class CircleValidator : AbstractValidator<Circle>
    {
        private readonly double _maxRadius = Math.Sqrt(double.MaxValue) / Math.PI;

        public CircleValidator()
        {
            CascadeMode = StopOnFirstFailure;

            RuleFor(c => c.Radius).LessThanOrEqualTo(_maxRadius)
                .WithMessage($"Значение радиуса круга не должно превышать { _maxRadius }");

            RuleFor(c => c.Radius).GreaterThan(0F)
                .WithMessage("Значение радиуса круга должно быть больше нуля.");
        }
    }
}