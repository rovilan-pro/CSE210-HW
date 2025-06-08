using System;
using System.Threading;
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration; //seconds

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("Starting.");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Congratulations!");
        Console.WriteLine($"You have completed {_duration} seconds in to {_name}.");
        Console.WriteLine();
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        var spinner = new[] { "|", "//", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b\b");
            i = (i+1) % spinner.Length;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}