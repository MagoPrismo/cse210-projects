using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string name = UserName();
        int number = UserNumber();

        int square = SquareNumber(number);

        FinalMessage(name, square);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }

    static string UserName()
    {
        Console.Write("What's your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int UserNumber()
    {
        Console.Write("What's your favorite number? ");
        int x = int.Parse(Console.ReadLine());
        
        return x;
    }

    static int SquareNumber(int number)
    {
        int result = number * number;

        return result;
    }

    static void FinalMessage(string name, int square)
    {
        Console.WriteLine($"Your name is {name}, and the square of you {square}");
    }
}
