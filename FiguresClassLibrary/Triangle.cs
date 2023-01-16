public class Triangle : IFigure
{
    public Triangle(double x, double y, double z)
    {
        SideA = x;
        SideB = y;
        SideC = z;
    }

    private double _firstSide;
    private double _secondSide;
    private double _thirdSide;
    private double? _square;
    private bool? _isRight;

    public double SideA
    {
        get { return _firstSide; }
        private set
        {
            Validate(value);
            _firstSide = value;
        }
    }

    public double SideB
    {
        get { return _secondSide; }
        private set
        {
            Validate(value);
            _secondSide = value;
        }
    }

    public double SideC
    {
        get { return _thirdSide; }
        private set
        {
            Validate(value);
            _thirdSide = value;
        }
    }

    private void Validate(double value)
    {
        if (!IsValid(value))
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Значение должно быть больше 0");
        }
    }

    private bool IsValid(double value)
    {
        return value > 0;
    }

    public double GetSquare()
    {
        if (_square is null)
        {
            var p = (_firstSide + _secondSide + _thirdSide) / 2;
            var S = Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
            _square = S;
        }

        return (double)_square;
    }

    public bool IsRight()
    {
        if (_isRight is null)
        {
             _isRight = SideA == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
                || SideB == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
                || SideC == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideA, 2));
        }
        return (bool)_isRight;
    }
}
