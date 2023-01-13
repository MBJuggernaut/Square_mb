namespace Square_mb_ConsoleApp;

public partial class Program
{
    public class Circle : IFigure
    {
        public Circle(decimal radius)
        {
            _radius = radius;
        }

        private decimal _radius;

        public decimal GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}