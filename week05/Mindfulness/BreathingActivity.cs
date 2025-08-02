public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    public void Run()
    {
        base.DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base._duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreath In...  ");
            base.ShowCountDown(3);
            Console.Write("\nBreath Out...  ");
            base.ShowCountDown(5);
            Console.WriteLine("");
        }
        base.DisplayEndingMessage();
    }
}