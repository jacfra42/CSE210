using System;

class Program
{
    static void Main(string[] args)
    {
        string bName = "Breathing Activity";
        string bDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string rName = "Reflecting Activty";
        string rDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string lName = "Listing Activty";
        string lDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        List<string> rPrompts = new List<string>();
        rPrompts.Add("Think of a time when you stood up for someone else.");
        rPrompts.Add("Think of a time when you did something really difficult.");
        rPrompts.Add("Think of a time when you helped someone in need.");
        rPrompts.Add("Think of a time when you did something truly selfless.");
        List<string> rQuestions = new List<string>();
        rQuestions.Add("Why was this experience meaningful to you?");
        rQuestions.Add("Have you ever done anything like this before?");
        rQuestions.Add("How did you get started?");
        rQuestions.Add("How did you feel when it was complete?");
        rQuestions.Add("What made this time different than other times when you were not as successful?");
        rQuestions.Add("What is your favorite thing about this experience?");
        rQuestions.Add("What could you learn from this experience that applies to other situations?");
        rQuestions.Add("What did you learn about yourself through this experience?");
        rQuestions.Add("How did you get started?");
        rQuestions.Add("How can you keep this experience in mind in the future?");

        List<string> lPrompts = new List<string>();
        lPrompts.Add("Who are people that you appreciate?");
        lPrompts.Add("What are personal strengths of yours?");
        lPrompts.Add("Who are people that you have helped this week?");
        lPrompts.Add("When have you felt the Holy Ghost this month?");
        lPrompts.Add("Who are some of your personal heroes?");

        Console.Clear();
        string input = "";
        while (input != "4")
        {
            Console.WriteLine("Menu Options:\n  1. Start Breathing Activity\n  2. Start Reflecting Activity\n  3. Start Listing Activity");
            Console.Write("  4. Quit\nSelect a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity breathing = new BreathingActivity(bName, bDescription);
                breathing.Run();
            }
            if (input == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity(rName, rDescription, rPrompts, rQuestions);
                reflecting.Run();
            }
            if (input == "3")
            {
                ListingActivity listing = new ListingActivity(lName, lDescription, lPrompts);
                listing.Run();
            }
        }
    }
}