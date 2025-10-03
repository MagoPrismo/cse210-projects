public class Product
{
    private string _name;
    public int _id;
    private double _price;
    private int _quantity;
    public int Id
    {
        get { return _id; }
    }

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double Cost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _id;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}