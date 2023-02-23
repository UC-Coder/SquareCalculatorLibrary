namespace SquareCalculatorLibrary.Tests
{
    public class PolygonTests
    {
        /// <summary>
        /// Проверка количества ячеек и площади (если пользователь ввел 0).
        /// </summary>
        [Test]
        public void CheckCountsAndSquare_ArgumentOutOfRangeException()
        {
            int fullCellCount = 0;
            int partialCellCount = 0;
            double squarePerCell = 0.0;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Polygon(fullCellCount, 10, 1.0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Polygon(10, partialCellCount, 1.0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Polygon(10, 10, squarePerCell));
        }

        /// <summary>
        /// Проверка вычисления площади многоугольника
        /// </summary>
        [Test]
        public void PolygonSquareCalculate()
        {

            int fullCellCount = 36;
            int partialCellCount = 36;
            double squarePerFullCell = 5.0;

            double expected = 270.0;

            Polygon polygon = new Polygon(fullCellCount, partialCellCount, squarePerFullCell);
            double result = polygon.Square;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
