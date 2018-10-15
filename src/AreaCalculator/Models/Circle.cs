namespace AreaCalculator.Models
{
    public class Circle : IFigure
    {
        public Circle()
        {
            
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public string FigureTypeName => "Круг заданный радиусом";
    }
}