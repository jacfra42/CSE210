using System;

class Program
{
    static void Main(string[] args)
    {
        Run run = new Run(3, 30);
        Bike bike = new Bike(14, 30);
        Swim swim = new Swim(8, 30);

        List<Activity> list = new List<Activity>();
        list.Add(run);
        list.Add(bike);
        list.Add(swim);

        foreach (Activity a in list)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}