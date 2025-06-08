using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "Activity about Reflecting", 20)
    {
        _prompts = new List<string>
        {
            "Think of a time when you enjoyed the most.",
            "Think of a time when you achieved something that you're very proud of.",
            "Think of a time when you feel alive the most."
        };

        _questions = new List<string>
        {
            "What are your challenges?",
            "What do you feel when studying?",
            "How do you usually do your morning routine?",
            "What did you learn from life experiences?",
            "What are your Thoughts?"
        };

    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Consider the following.");
        DisplayPrompt();

        Console.WriteLine();
        Console.Write("Write what's in your mind, Press Enter to continue.");
        Console.WriteLine();

        Console.WriteLine("Think of the following.");
        Console.Write("Starting.");
        Console.WriteLine();
        ShowCountDown(5);

        Console.Clear();
        DisplayQuestions();
         
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {   
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine($"> {prompt}");
            Console.WriteLine();
            ShowSpinner(10);
            Console.WriteLine();
        }
        
    }
    public void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question} ");
            Console.WriteLine();
            ShowSpinner(10);
            Console.WriteLine();
        }
    }
}