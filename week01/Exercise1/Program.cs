// Name: Rovilan Alec Dela Torre
//With Guide

using System;
//Class Program
class Program
{   
    // Static, Void, string
    static void Main(string[] args)
    {
        //Question-Write to Input Something
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        //Question
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        //Output-Give Result with Prompt f=$ (Phyton = C#)
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}