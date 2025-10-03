using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference referenceAll = new Reference("Matthew", 14, 19);
        string reference = referenceAll.GetReference();
        string verse = "And He directed the crowds to sit down on the grass. Taking the five loaves and the two fish and looking up to heaven, He spoke a blessing. Then He broke the loaves and gave them to the disciples, and the disciples gave them to the people.";
        Scripture scripture = new Scripture(reference, verse);
        while (!scripture.IsAllHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(2);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}