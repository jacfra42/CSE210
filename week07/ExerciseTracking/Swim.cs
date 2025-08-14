public class Swim : Activity
{
    private double _laps;

    public Swim(double laps, double time) : base(time)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
    public override double GetPace()
    {
        return base._time / GetDistance();
    }
    public override string GetDetails()
    {
        return $"Swimming";
    }
}