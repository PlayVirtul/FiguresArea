namespace FiguresArea.Figures
{
    public class Circle : Figure
    {
        /// <summary>
        /// Инициалиция круга.
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentOutOfRangeException">Исключение при отрицательном радиусе.</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным или 0");
            }
            Radius = radius;
        }

        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Вычисление площади круга.
        /// </summary>
        /// <returns></returns>
        protected override double CalculateArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
