using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("\n-------------------First Order-------------------");
        //first order
        Product product1 = new Product("milk", 3, 4.5, 2);
        Product product2 = new Product("chocolate", 2, 9.0, 3);
        Product product3 = new Product("bread", 5, 2.5, 7);

        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);
        products1.Add(product3);

        Address address1 = new Address("Park7", "Provo", "Utah", "USA");
        Customer john = new Customer("John", address1);

        Order order1 = new Order(products1, john);

        order1.GetShippingLabel();
        Console.WriteLine($"The total is: ${order1.Total()}");
        order1.GetPackingLabel();

        //second order
        Console.WriteLine("-------------------Second Order-------------------");
        Product product4 = new Product("carrot", 6, 0.90, 8);
        Product product5 = new Product("apple", 19, 3.5, 4);
        Product product6 = new Product("pie", 12, 5, 1);

        List<Product> products2 = new List<Product>();
        products2.Add(product4);
        products2.Add(product5);
        products2.Add(product6);

        Address address2 = new Address("Rua 38", "Valparaiso", "Goias", "BRZ");
        Customer mary = new Customer("Mary", address2);

        Order order2 = new Order(products2, mary);

        order2.GetShippingLabel();
        Console.WriteLine($"The total is: ${order2.Total()}");
        order2.GetPackingLabel();
    }
}