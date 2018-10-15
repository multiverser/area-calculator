using AreaCalculator.Models;
using AreaCalculator.Services.Verification;

namespace AreaCalculator
{
    public static class TriangleExtensions
    {
        public static bool? IsRightTriangle(this Triangle triangle) => 
            new RightTriangleVerifier(triangle).IsRightTriangle();
    }
}