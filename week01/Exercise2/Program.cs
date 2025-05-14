// Name: Rovilan Alec Dela Torre
using System;
class Program
{
    static void Main(string[] args)
    {
        //Question
        Console.Write("What is your grade percentage? ");
        //Function 
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        //Variables
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        //Output
        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
