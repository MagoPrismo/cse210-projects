using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment test1 = new Assignment("john", "math");
        Console.WriteLine(test1.GetSummary());

        MathAssignment test2 = new MathAssignment("john", "math", "7.3", "10-15");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetHomeWorkList());

        WritingAssignment test3 = new WritingAssignment("Mary", "Wars", "World War II");
        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInformation());
    }
}