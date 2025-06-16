using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Main started.");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
