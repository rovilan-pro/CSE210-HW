public class Comment
{
    public string _person;
    public string _text;

    public Comment(string person, string text)
    {
        _person = person;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{_person}: {_text}");
    }
}