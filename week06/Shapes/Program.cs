using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.\n");

        List<Shape> lista = new List<Shape>();
        Square square1 = new Square("red", 10);
        Rectangle rectangle1 = new Rectangle("blue", 10, 20);
        Circle circle1 = new Circle("green", 10);

        lista.Add(square1);
        lista.Add(rectangle1);
        lista.Add(circle1);

        foreach (var i in lista)
        {
            Double area = i.GetArea();
            String color = i.GetColor();
            Console.WriteLine($"{i.GetType()}\nColor: {color}\nArea: {Math.Round(area, 2)} m²\n");            
        }
    }
}