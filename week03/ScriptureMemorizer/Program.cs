using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "Proverbs";
        int chapter = 3;
        int verse = 5;
        int end_Verse = 6;
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thye ways acknowledge him, and he shall direct thy paths.";

        Reference reference = new Reference(book, chapter, verse, end_Verse);
        Scripture scripture = new Scripture(reference, scriptureText);

        string input = "";
        while (input != "quit")
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()}\n");
            Console.WriteLine("Press enter to continue, or type 'quit' to quit:");
            input = Console.ReadLine();
            scripture.HideRandomWords(3);
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine($"{scripture.GetDisplayText()}\n");
                Console.WriteLine("Press enter to continue, or type 'quit' to quit:");
                return;
            }
        }
    }
}