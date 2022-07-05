namespace FiguresArea.Figures
{
    public abstract class Figure
    {
        private readonly Lazy<double> _area;

        protected Figure()
        {
            _area = new Lazy<double>(CalculateArea);
        }

        public double Area => _area.Value;

        protected abstract double CalculateArea();
    }
}