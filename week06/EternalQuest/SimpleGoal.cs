public class SimpleGoal : Goal
{

    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string shortName, string description, int points, bool isComplete)
: base(shortName, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Goal \"{GetShortName()}\" completed! +{GetPoints()} points. ");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
    
    public override string GetDetailsString()
    {
    string status = IsComplete() ? "[X]" : "[ ]";
    return $"{status} {GetShortName()} ({GetDescription()})";
    }
}