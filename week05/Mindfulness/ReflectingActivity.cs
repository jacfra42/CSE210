public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }
    public void Run()
    {
        base.DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        base.DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {   
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"{GetRandomPrompt()}\n");
        base.ShowSpinner(10);
    }
    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base._duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            base.ShowSpinner(7);
        }
    }
}