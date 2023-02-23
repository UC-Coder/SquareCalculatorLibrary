namespace SquareCalculatorLibrary.Tests
{
    public class CircleTests
    {
        /// <summary>
        /// Проверка радиуса круга. Радиус круга не может быть 0.
        /// </summary>
        [Test]
        public void CheckRadius_ArgumentOutOfRangeException()
        {
            double radius = 0.0;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        /// <summary>
        /// Проверка радиуса круга. Радиус круга не может быть отрицательным значением.
        /// </summary>
        [Test]
        public void CheckRadius_ArgumentOutOfRangeException2()
        {
            double radius = -2.0;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        /// <summary>
        /// Проверка вычисления площадки круга с радиусом 1.
        /// </summary>
        [Test]
        public void CircleSquareCalculate_x1()
        {
            double radius = 1;
            double expected = Math.PI;

            Circle circle = new Circle(radius);
            double result = circle.Square;
            Assert.That(result, Is.EqualTo(expected));
        }

        /// <summary>
        /// Проверка вычисления площадки круга с радиусом sqrt(2).
        /// </summary>
        [Test]
        public void CircleSquareCalculate_x2()
        {
            double radius = Math.Sqrt(2.0);
            double expected = 6.283185307179588d;

            Circle circle=new Circle(radius);
            double result = circle.Square;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}