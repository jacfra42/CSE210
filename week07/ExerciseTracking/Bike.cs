public class Bike : Activity
{
    private double _speed;
    public Bike(double speed, double time) : base(time)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed / 60 * base._time;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetDetails()
        {
            return $"Cycling";
        }
}