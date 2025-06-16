public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
    : base(shortName, description, points)
    {

    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Progress recorded for \"{GetShortName()}\"! +{GetPoints()} points. ");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()},{GetDescription()},{GetPoints()}";
    }
    
    public override string GetDetailsString()
    {
        return $" {GetShortName()} ({GetDescription()})";
    }
}