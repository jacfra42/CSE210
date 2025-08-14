public class Run : Activity
{
    private double _distance;

    public Run(double distance, double time) : base(time)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
    public override double GetPace()
    {
        return base._time / _distance;
    }
    public override string GetDetails()
    {
        return $"Running";
    }
}