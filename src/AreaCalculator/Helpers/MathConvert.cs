using System;

namespace AreaCalculator.Helpers
{
    /// <summary>
    /// Вспомогательный класс содержащий статические методы для работы с числами.
    /// </summary>
    internal static class MathConvert
    {
        /// <summary>
        /// Получает значение точности для округления вещественных чисел.
        /// </summary>
        public static double Precision => 0.0001;

        /// <summary>
        /// Возвращает в радианах переданное в градусах значение.
        /// </summary>
        /// <param name="degrees">
        /// Значение в градусах для конвертации в радианы.
        /// </param>
        /// <returns>
        /// Возвращает в радианах переданное в градусах значение.
        /// </returns>
        public static double ToRadians(double degrees) => degrees / 180F * Math.PI;

        /// <summary>
        /// Возвращает в градусах переданное в радианах значение.
        /// </summary>
        /// <param name="radians">
        /// Значение в радианах для конвертации в градусы.
        /// </param>
        /// <returns>
        /// Возвращает в градусах переданное в радианах значение.
        /// </returns>
        public static double ToDegrees(double radians) => radians * 180F / Math.PI;
    }
}