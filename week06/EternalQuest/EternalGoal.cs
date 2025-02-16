public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        // No completion, but user still earns points
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals never complete
    }

    public override string GetDetailsString()
    {
        return "[∞] " + _shortName;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}