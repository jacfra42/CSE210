public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, string target, string bonus, string amountCompleted = "0") : base(name, description, points)
    {
        _amountCompleted = int.Parse(amountCompleted);
        _target = int.Parse(target);
        _bonus = int.Parse(bonus);
    }
    public override int RecordEvent()
    {
        _amountCompleted += 1;
        if (IsComplete())
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }

    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[x] {_shortName}: {_description} -- {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName}: {_description} -- {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"3|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}