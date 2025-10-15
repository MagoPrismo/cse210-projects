public class Circle : Shape
{
    private Double _radius = 0.0;

    public Circle(String color, Double radius) : base(color)
    {
        _radius = radius;
    }

    public override Double GetArea()
    {
        return Math.PI * _radius;
    }
}