public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

        public CheckListGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }


    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            Console.WriteLine($"Goal \"{GetShortName()}\" completed! +{GetPoints()} points. ");

            if (IsComplete())
            {
                Console.WriteLine($"Goal completed! Bonus +{_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine($"\"{GetShortName()}\" is already complete.");
        }
    }
    

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";

        return $"{status} {GetShortName()} ({GetDescription()})  -- Completed {_amountCompleted}/{_target}.";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }

}