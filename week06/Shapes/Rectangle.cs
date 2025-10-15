public class Rectangle : Shape
{
    private Double _length = 0.0;
    private Double _width = 0.0;

    public Rectangle(String color, Double length, Double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override Double GetArea()
    {
        return _length * _width;
    }
}