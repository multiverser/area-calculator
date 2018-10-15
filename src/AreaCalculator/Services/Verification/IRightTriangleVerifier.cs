namespace AreaCalculator.Services.Verification
{
    public interface IRightTriangleVerifier
    {
        /// <summary>
        /// Возвращает <see langword="true" /> для прямоугольного треугольника,
        /// иначе <see langword="false" />. Или <see langword="null" /> при отсутствии возможности расчета. 
        /// </summary>
        bool? IsRightTriangle();
    }
}