namespace SquareCalculatorLibrary
{
    public class Triangle:Figure
    {
        readonly List<double> sides;

        /// <summary>
        /// Первая сторона треугольника.
        /// </summary>
        public double FirstSide => sides[0];
        /// <summary>
        /// Вторая сторона треугольника.
        /// </summary>
        public double SecondSide => sides[1];
        /// <summary>
        /// Третья сторона треугольника.
        /// </summary>
        public double ThirdSide => sides[2];


        bool? isRightTriangle = null;
        /// <summary>
        /// Свойство возвращает true, если прямоугольник является прямоугольным, 
        /// и false, если треугольник не является прямоугольным.
        /// </summary>
        public bool IsRightTriangle
        {
            get
            {
                isRightTriangle ??= CheckRightTriangle();
                return (bool)isRightTriangle;
            }
        }

        /// <summary>
        /// Треугольник.
        /// </summary>
        /// <param name="firstSide">Первая сторона треугольника.</param>
        /// <param name="secondSide">Вторая сторона треугольника.</param>
        /// <param name="thirdSide">Третья сторона треугольника.</param>
        /// <exception cref="ArgumentOutOfRangeException">Исключение, если сторона треугольника меньше или равна 0</exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < double.Epsilon)
                throw new ArgumentOutOfRangeException(nameof(firstSide), "Первая сторона треугольника должна быть больше 0.");
            if (secondSide < double.Epsilon)
                throw new ArgumentOutOfRangeException(nameof(secondSide), "Вторая сторона треугольника должна быть больше 0.");
            if (thirdSide < double.Epsilon)
                throw new ArgumentOutOfRangeException(nameof(thirdSide), "Третья сторона треугольника должна быть больше 0.");

            sides = new() { firstSide, secondSide, thirdSide };
        }

        /// <summary>
        /// Вычисление площади треугольника.
        /// </summary>
        internal override double CalculateSquare()
        {
            double semiPerimeter = sides.Sum() / 2;
            double result = Math.Sqrt(semiPerimeter * sides.Sum(side => semiPerimeter - side));
            return result;
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>Возвращает true, если прямоугольник является прямоугольным, 
        /// и false, если треугольник не является прямоугольным.</returns>
        bool CheckRightTriangle()
        {
            double max = sides.Max();
            double delta = 0.01;
            if (max * max - (sides.Sum(x => x * x) - max * max) <= delta)
                return true;
            else
                return false;
        }
    }
}
