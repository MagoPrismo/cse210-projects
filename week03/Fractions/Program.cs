using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction numb1 = new Fraction();
        string result1 = numb1.GetFractionString();
        double result2 = numb1.GetDecimalValue();
        Console.WriteLine(result1);
        Console.WriteLine(result2);

        Fraction numb2 = new Fraction(5);
        string result3 = numb2.GetFractionString();
        double result4 = numb2.GetDecimalValue();
        Console.WriteLine(result3);
        Console.WriteLine(result4);

        Fraction numb3 = new Fraction(1,3);
        string result5 = numb3.GetFractionString();
        double result6 = numb3.GetDecimalValue();
        Console.WriteLine(result5);
        Console.WriteLine(result6);
    }
}