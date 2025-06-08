using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "Activity About Listing",30)
    {
        _prompts = new List<string>
        {
            "What are your goals for today?",
            "Who did you meet today?",
            "When did you feet the Holy Ghost this day?"
        };
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"-{prompt}-");
        Console.WriteLine();

        Console.WriteLine("List as many as possible:");
        Console.WriteLine("You may begin.");
        Console.WriteLine();
        ShowCountDown(10);

        GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    public void GetListFromUser()
    {
        _count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                _count++;
            } 
        }
    }
}