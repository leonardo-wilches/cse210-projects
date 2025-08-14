public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(bool isCompleted, string name, string description, int points) : base(name, description, points)
    {
        _isComplete = isCompleted;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}