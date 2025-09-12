using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number != 0)
        {
            Console.Write("What's the number you wanna add? ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);   
            }
        }

        float largest = 0;

        foreach (float num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        float total = numbers.Sum();
        float mean = total / numbers.Count();
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {mean}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}