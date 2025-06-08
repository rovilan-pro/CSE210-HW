public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "Activity about Breathing", 36)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Proceeding to Breathing exercises. Breath slowly and observe the screen.");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in..........");
            Console.WriteLine();    
            ShowCountDown(6);
            
            Console.Write("Breath out.........");
            Console.WriteLine();
            ShowCountDown(6);

            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}