namespace SquareCalculatorLibrary.Tests
{
    public class TriangleTests
    {
        /// <summary>
        /// Проверка сторон треугольника (если пользователь ввел 0).
        /// </summary>
        [Test]
        public void CheckSide_ArgumentOutOfRangeException()
        {
            double firstSide = 0.0;
            double secondSide = 0.0;
            double thirdSide = 0.0;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(firstSide, 1.0, 1.0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1.0, secondSide, 1.0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1.0, 1.0, thirdSide));
        }

        /// <summary>
        /// Проверка сторон треугольника (если пользователь ввел отрицательное значение).
        /// </summary>
        [Test]
        public void CheckSide_ArgumentOutOfRangeException_EqualNegative()
        {
            double firstSide = -1.0;
            double secondSide = -1.0;
            double thirdSide = -1.0;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(firstSide, 1.0, 1.0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1.0, secondSide, 1.0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1.0, 1.0, thirdSide));
        }

        /// <summary>
        /// Проверка вычисления площади треугольника.
        /// </summary>
        [Test]
        public void TriangleSquareCalculate()
        {
            double firstSide = 3.0;
            double secondSide = 4.0;
            double thirdSide = 5.0;

            double square = 6.0;

            double result = new SquareCalculatorLibrary.Triangle(firstSide, secondSide, thirdSide).Square;
            Assert.That(result, Is.EqualTo(square));
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным (true).
        /// </summary>
        [Test]
        public void IsRightTriangle_True()
        {
            double firstSide = 3.0;
            double secondSide = 4.0;
            double thirdSide = 5.0;

            Triangle triangle=new(firstSide, secondSide, thirdSide);
            bool result = triangle.IsRightTriangle;
            Assert.That(result, Is.True);
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным (false).
        /// </summary>
        [Test]
        public void IsRightTriangle_True2()
        {
            double firstSide = 3.0;
            double secondSide = 10.0;
            double thirdSide = 50.0;

            Triangle triangle=new(firstSide, secondSide, thirdSide);
            bool result = triangle.IsRightTriangle;
            Assert.That(result, Is.False);
        }
    }
}
