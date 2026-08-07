public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return -_points; // Deducts points
    }

    public override bool IsComplete()
    {
        return false; // Bad habits are never fully "complete"
    }

    public override string GetDetailsString()
    {
        return $"[-] {_shortName} ({_description}) [Negative Goal]";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points}";
    }
}