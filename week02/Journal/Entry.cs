public class Entry
{
    public string _DateTime;
    public string _PromptText;
    public string _EntryText;

    //Display, Output of Entry
    public void Display()
    {
        Console.WriteLine($"{_DateTime}, {_PromptText} -- {_PromptText}");
    }
}