namespace SquareCalculatorLibrary
{
    public class Polygon:Figure
    {
        int fullCellCount;

        /// <summary>
        /// Количество целых ячеек.
        /// </summary>
        public int FullCellCount => fullCellCount;

        int partialCellCount;
        /// <summary>
        /// Количество дробных ячеек.
        /// </summary>
        public int PartialCellCount => partialCellCount;

        double squarePerFullCell;

        /// <summary>
        /// Площадь одной ячейки.
        /// </summary>
        public double SquarePerFullCell => squarePerFullCell;

        /// <summary>
        /// Многоугольник
        /// <para>Для проведения расчетов площади многоугольника необходимо разибть многоугольник на ячейки.
        /// Затем необходимо посчитать количество целых и дробных ячеек, а также определить площадь одной ячейки.</para> 
        /// <para>Комментарий: чем меньше площадь ячейки, тем выше будет точность определения площади многоугольника. 
        /// Особенно, если он сложной конфигурации.</para>
        /// </summary>
        /// <param name="fullCellCount">Количество целых ячеек.</param>
        /// <param name="partialCellCount">Количество дробных ячеек.</param>
        /// <param name="squarePerFullCell">Площадь одной ячейки.</param>
        /// <exception cref="ArgumentOutOfRangeException">Исключение, если количество ячеек или площадь меньше или равна 0</exception>
        public Polygon(int fullCellCount, int partialCellCount, double squarePerFullCell)
        {
            if (fullCellCount < double.Epsilon) throw new ArgumentOutOfRangeException(nameof(fullCellCount), "Количество целых ячеек должно быть больше 0.");
            if (partialCellCount < double.Epsilon) throw new ArgumentOutOfRangeException(nameof(partialCellCount), "Количество дробных ячеек должно быть больше 0.");
            if (squarePerFullCell < double.Epsilon) throw new ArgumentOutOfRangeException(nameof(squarePerFullCell), "Площадь ячейки должна быть больше 0.");

            this.fullCellCount = fullCellCount;
            this.partialCellCount = partialCellCount;
            this.squarePerFullCell = squarePerFullCell;
        }

        /// <summary>
        /// Вычисление площади многоугольника.
        /// </summary>
        internal override double CalculateSquare()
        {
            return (fullCellCount + partialCellCount / 2) * squarePerFullCell;
        }
    }
}
