using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment writing = new WritingAssignment("Tommy", "Fish", "Why Fish Bite Hooks");
        Console.WriteLine($"{writing.GetSummary()}");
        Console.WriteLine($"{writing.GetWritingInformation()}");
    }
}