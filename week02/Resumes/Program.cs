using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "NHL";
        job1._jobTitle = "Goalie";
        job1._startYear = 2007;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "MLB";
        job2._jobTitle = "Catcher";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Billy Smith";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();

    }

}