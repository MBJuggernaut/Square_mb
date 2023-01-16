public class Circle : IFigure
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    private double _radius;
    private double? _square;

    public double Radius
    {
        get
        {
            return _radius;
        }
        private set
        {
            Validate(value);
            _radius = value;
        }
    }

    private void Validate(double value)
    {
        if (!IsValid(value))
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Значение должно быть больше ноля");
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
            _square = Math.PI * Math.Pow(Radius, 2);
        }
        return (double)_square;
    }
}
