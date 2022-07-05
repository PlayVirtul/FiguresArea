namespace FiguresArea.Figures
{
    public class Triangle : Figure
    {
        private Lazy<bool> _isRightTriangle;

        /// <summary>
        /// Инициализация треугольника.
        /// </summary>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="thirdSide"></param>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentOutOfRangeException("Стороны треугольника не могут быть меньше или равны 0.");
            }
            if (!IsTriangleExist(firstSide, secondSide, thirdSide))
            {
                throw new ArgumentException("Треугольника с такими сторонами не может существовать.");
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            _isRightTriangle = new Lazy<bool>(CheckIsRightTriangle);
        }

        /// <summary>
        /// Прямоугольный ли треугольник.
        /// </summary>        
        public bool IsRightTriangle => _isRightTriangle.Value;

        /// <summary>
        /// Первая сторона треугольника.
        /// </summary>
        public double FirstSide { get; }

        /// <summary>
        /// Вторая сторона треугольника.
        /// </summary>
        public double SecondSide { get; }

        /// <summary>
        /// Третья сторона треугольника.
        /// </summary>
        public double ThirdSide { get; }

        /// <summary>
        /// Вычисление площади треугольника.
        /// </summary>
        /// <returns></returns>
        protected override double CalculateArea()
        {
            // учесть, что треугольника не может быть
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math
                .Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        }

        /// <summary>
        /// Проверка на прямоугольность треугольника.
        /// </summary>
        /// <returns></returns>
        private bool CheckIsRightTriangle()
        {
            var maxSide = new[] { FirstSide, SecondSide, ThirdSide }.Max();
            var maxSideSqr = maxSide * maxSide;

            return
                maxSideSqr + maxSideSqr == Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2);
        }

        /// <summary>
        /// Проверка, что треугольник существует.
        /// </summary>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="thirdSide"></param>
        /// <returns></returns>
        private bool IsTriangleExist(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide + secondSide > thirdSide)
            {
                if (firstSide + thirdSide > secondSide)
                {
                    if (secondSide + thirdSide > firstSide)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}