public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius) :base(color)
    {
        _radius = radius;
    }

    const double Pi = Math.PI;

    public override double GetArea()
    {
        return Pi * Math.Pow(_radius,2);
    }
    
}