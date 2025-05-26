using System;

class Program
{
    static void Main(string[] args)
    {   
        var reference = new Reference("Moroni", 10, 5, 6);
        string scriptureText = "And by the power of the Holy Ghost ye may know the truth of all things. And whatsoever thing is good is just and true; wherefore, nothing that is good denieth the Christ, but acknowledgeth that he is.";
        var scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(5); 

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nProgram ending.");
                break;
            }
        }
    }
}