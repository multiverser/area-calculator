using AreaCalculator.Models;
using FluentValidation;
using static FluentValidation.CascadeMode;

namespace AreaCalculator.Services.Validation
{
    /// <summary>
    /// Валидатор типа <see cref="Triangle" />.
    /// </summary>
    internal class TriangleValidator : AbstractValidator<Triangle>
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public TriangleValidator()
        {
            CascadeMode = StopOnFirstFailure;

            RuleFor(t => t.SideA).GreaterThan(0F)
                .WithMessage("Сторона A должна быть больше нуля.");
            RuleFor(t => t.SideB).GreaterThan(0F)
                .WithMessage("Сторона B должна быть больше нуля.");
            RuleFor(t => t.SideC).GreaterThan(0F)
                .WithMessage("Сторона C должна быть больше нуля.");

            RuleFor(t => t.SideA).LessThan(t => t.SideB + t.SideC)
                .WithMessage("Сторона А должна быть меньше суммы двух других сторон.");
            RuleFor(t => t.SideB).LessThan(t => t.SideA + t.SideC)
                .WithMessage("Сторона B должна быть меньше суммы двух других сторон.");
            RuleFor(t => t.SideC).LessThan(t => t.SideA + t.SideB)
                .WithMessage("Сторона C должна быть меньше суммы двух других сторон.");

            RuleFor(t => t.SideC)
                .GreaterThan(t => t.SideA)
                    .WithMessage("Сторона C(гипотенуза) должна быть больше строны A.")
                .GreaterThan(t => t.SideB)
                    .WithMessage("Сторона C(гипотенуза) должна быть больше строны B.");
        }
    }
}