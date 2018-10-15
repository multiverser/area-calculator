namespace AreaCalculator
{
    /// <summary>
    /// Интерфейс геометрической фигуры.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Получает наименование типа геометрической фигуры.
        /// </summary>
        string FigureTypeName { get; }
    }
}