public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"\nCongratulations, you got {_points}\n");
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{IsComplete()}";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
}