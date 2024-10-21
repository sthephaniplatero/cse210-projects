public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double lenght, double width) :base(color)
    {
        _length = lenght;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
    
}