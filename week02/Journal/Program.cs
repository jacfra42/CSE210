using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        string input = "";
        while (input != "5")
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            input = Console.ReadLine();

            if (input == "1")
            {
                Entry entry = new Entry();
                myJournal.AddEntry(entry);
            }
            if (input == "2")
            {
                myJournal.DisplayAll();
            }
            if (input == "3")
            {
                Console.WriteLine("Enter file name: ");
                string file = Console.ReadLine();
                myJournal.LoadFromFile(file);
                int streak = myJournal.GetStreak();
                Console.WriteLine($"\nYou have written in your journal {streak} days in a row!\n");
                // Added a method to the Journal class to see how many days in a row the journal has been written in.
            }
            if (input == "4")
            {
                Console.WriteLine("Enter file name: ");
                string file = Console.ReadLine();
                myJournal.SaveToFile(file);
            }
        }
    }
}