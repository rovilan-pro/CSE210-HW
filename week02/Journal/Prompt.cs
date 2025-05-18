using System;
using System.Collections.Generic;

public class Prompt
{
    //List
    public List<string> _prompts = new List<string>
    {
      "Who made you smile today?",
      "What did you learn today?",
      "What did you enjoy the most today?",
      "Write your goals for today.",
      "Write your achievements for today."
    };

    //Prompt Generator
    public string GiveRandomPrompt()
    {
        Random randoM = new Random();
        int index = randoM.Next(_prompts.Count);
        return _prompts[index];
    }
}