public abstract class Activity
{
    protected double _time;

    public Activity(double time)
    {
        _time = time;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetDetails();

    public string GetSummary()
    {
        DateTime today = DateTime.Now;
        return $"{today} {GetDetails()} ({_time} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}