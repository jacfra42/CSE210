public abstract class Goal
{
    public string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = int.Parse(points);
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[x] {_shortName}: {_description}";
        }
        else
        {
            return $"[ ] {_shortName}: {_description}";
        }
    }
    public abstract string GetStringRepresentation();
}