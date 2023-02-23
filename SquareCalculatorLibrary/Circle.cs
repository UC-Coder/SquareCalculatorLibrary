namespace SquareCalculatorLibrary
{
    public class Circle:Figure
    {
        readonly double radius;

        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius => radius;

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentOutOfRangeException">Исключение, если радиус круга меньше или равен 0</exception>
        public Circle(double radius)
        {
            if (radius < double.Epsilon) throw new ArgumentOutOfRangeException(nameof(radius), "Радиус круга должен быть больше 0");
            this.radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        internal override double CalculateSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
