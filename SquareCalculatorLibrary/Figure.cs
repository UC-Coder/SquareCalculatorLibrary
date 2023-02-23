namespace SquareCalculatorLibrary
{
    public abstract class Figure
    {
        double square;

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Square
        {
            get
            {
                if (square == 0.0)
                    square = CalculateSquare();
                return square;
            }
        }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        internal abstract double CalculateSquare();
    }
}