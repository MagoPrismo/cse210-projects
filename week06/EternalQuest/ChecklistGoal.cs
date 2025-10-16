public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _points = _bonus;
            Console.WriteLine($"Congratulations, you achieved your goal! You earned {_points}");
            _isComplete = true;
        }

        Console.WriteLine($"Congrats! you got {_points}");

    }

    public override string GetDetailsString()
    {
        string mark = " ";
        if (IsComplete())
        {
            mark = "X";
        }

        return $"[{mark}] {_shortName} ({_description}) => points: {_points} - {_amountCompleted}/{_target}";
    }

    public void SetAmount(int amount)
    {
        _amountCompleted = amount;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_target},{_bonus},{IsComplete()},{_amountCompleted}";
    }
}