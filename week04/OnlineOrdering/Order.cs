using System.Linq;
public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;
    private double _total;
    private int _shipping;

    public Order(List<Product> products, Customer customer)
    {
        _productList = products;
        _customer = customer;
    }

    private int Shipping() {
        
        if (_customer.USA())
        {
            return _shipping = 5;
        }
        else
        {
            return _shipping = 35;
        }
    }
    public double Total()
    {
        _total = 0;
        foreach (var item in _productList)
        {
            _total += item.Cost();
        }
        _shipping = Shipping();
        _total += _shipping;
        return _total;

    }

    public void GetPackingLabel()
    {
        Console.WriteLine("___________________Packing Label___________________");
        var productListSorted = _productList.OrderBy(p => p.Id);
        foreach (var item in productListSorted)
        {
            string name = item.GetName();
            int id = item.GetId();
            double price = item.GetPrice();
            int quantity = item.GetQuantity();
            Console.WriteLine($"({id}) {name}: {quantity} X ${price} = {item.Cost()}");
        }
        Console.WriteLine($"____________________________________Total = ${Total()}");
    }

    public void GetShippingLabel()
    {
        Console.WriteLine("___________________Shipping Label___________________");
        Console.WriteLine($"Customer: {_customer.GetName()}");
        Console.WriteLine("Address:" + _customer.GetAddress());
        Console.WriteLine($"Shipping cost: ${Shipping()}");
    }
}