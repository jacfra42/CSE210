public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
        _count = 0;
    }
    public void Run()
    {
        base.DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        base.ShowCountDown(9);
        List<string> userList = GetListFromUser(); 
        Console.WriteLine($"You listed {userList.Count} items\n");
        base.ShowSpinner(3);
        base.DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    public List<string> GetListFromUser()
    {
        List<string> inputList = new List<string>();
        Console.WriteLine("Start Listing Items:\n");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base._duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            inputList.Add(Console.ReadLine());
        }
        return inputList;
    }
}