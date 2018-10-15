using System;
using AreaCalculator.Exceptions;
using AreaCalculator.Models;
using AreaCalculator.Services.Calculation;

namespace AreaCalculator
{
    public static class FigureExtensions
    {
        /// <summary>
        /// Вычисляет и возвращает площадь геометрической фигуры
        /// или <see langword="null" /> в случае неудачи при расчете.
        /// </summary>
        /// <returns>
        /// Возвращает площадь геометрической фигуры или <see langword="null" />, в случае невозможности расчета.
        /// </returns>
        public static double? GetArea(this IFigure figure)
        {
            switch (figure.FigureTypeName)
            {
                case "Круг заданный радиусом":
                    return figure is Circle circle 
                        ? new CircleAreaCalculator(circle).Calculate() 
                        : default(double);
                case "Треугольник заданный тремя сторонами":
                    return figure is Triangle triangle 
                        ? new TriangleAreaCalculator(triangle).Calculate() 
                        : default(double);
                default:
                    throw new AreaCalculatorException(
                        $"Расчет площади фигуры типа '{figure.FigureTypeName}' в данный момент не поддерживается библиотекой.", 
                        new NotSupportedException());
            }
        }
    }
}