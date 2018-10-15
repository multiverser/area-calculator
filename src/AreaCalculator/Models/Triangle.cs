namespace AreaCalculator.Models
{
    /// <summary>
    /// Класс реализующий геометрическую фигуру типа: "Треугольник заданный тремя сторонами".
    /// </summary>
    public class Triangle : IFigure
    {
        public Triangle()
        {
            
        }

        /// <summary>
        /// Конструктор геометрической фигуры типа: "Треугольник заданный тремя сторонами".
        /// </summary>
        /// <param name="sideA">
        /// Сторона треугольника A.
        /// </param>
        /// <param name="sideB">
        /// Сторона треугольника B.
        /// </param>
        /// <param name="sideC">
        /// Сторона треугольника C(гипотенуза). 
        /// </param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; set; }

        public double SideB { get; set; }

        public double SideC { get; set; }

        public string FigureTypeName => "Треугольник заданный тремя сторонами";
    }
}