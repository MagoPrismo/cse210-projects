using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.\n");
        //To show creativity, I added RemoveAt for the activity 3 to not get same questions

        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select one activity from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity activity1 = new BreathingActivity();
                    activity1.DisplayStartingMessage();
                    activity1.GetReady();
                    activity1.Run();
                    activity1.DisplayEndingMessage();
                    break;

                case "2":
                    ListingActivity activity2 = new ListingActivity();
                    activity2.DisplayStartingMessage();
                    activity2.GetReady();
                    activity2.Run();
                    activity2.DisplayEndingMessage();
                    break;

                case "3":
                    ReflectingActivity activity3 = new ReflectingActivity();
                    activity3.DisplayStartingMessage();
                    activity3.GetReady();
                    activity3.Run();
                    activity3.DisplayEndingMessage();
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Thank You for playing! Goodbye!");
                    return;

                default:
                    //in the no matche case
                    Console.WriteLine("Invalid choice, try again a valid number!");
                    break;
            }
        }
    }
}