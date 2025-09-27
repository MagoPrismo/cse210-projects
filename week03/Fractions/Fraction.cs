public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop()
    {
        Console.WriteLine(_top);
    }
    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }

    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string result = $"{_top}/{_bottom}";
        return result;
    }

    public double GetDecimalValue()
    {
        double result = (double)_top / (double)_bottom;
        return result;
    }
}