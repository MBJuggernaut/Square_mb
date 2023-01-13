namespace Square_mb_ConsoleApp;

public partial class Program
{
    public class Triangle : IFigure
    {
        public Triangle(decimal x, decimal y, decimal z)
        {
            _firstSide = x;
            _secondSide = y;
            _thirdSide = z;
        }

        private decimal _firstSide;
        private decimal _secondSide;
        private decimal _thirdSide;

        public decimal GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}