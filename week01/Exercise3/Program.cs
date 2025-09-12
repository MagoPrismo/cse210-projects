using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

                Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int number = -1;

        while (number != magicNumber)
        {
            Console.Write("What's your guess? ");
            number = int.Parse(Console.ReadLine());

            if (number > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (number < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine($"You guessed it!! The Magic Number is {magicNumber}");
    }
}