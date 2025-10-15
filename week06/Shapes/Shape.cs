public abstract class Shape
{
    protected String _color = "";

    //constructor
    public Shape(String color)
    {
        _color = color;
    }
    public String GetColor()
    {
        return _color;
    }

    public void SetColor(String color)
    {
        _color = color;
    }

    public virtual Double GetArea()
    {
        return 0.0;
    }

}