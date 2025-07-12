using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;
        PromptGenerator getPrompt = new PromptGenerator();
        newEntry._promptText = getPrompt.GetRandomPrompt();
        Console.WriteLine($"{newEntry._promptText}");
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Dispaly();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            string[] parts = line.Split("|");
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            _entries.Add(newEntry);
        }
    }
    public int GetStreak()
    {
        List<string> dates = new List<string>();
        foreach (Entry entry in _entries)
        {
            dates.Add(entry._date);
        }
        var streakDates = dates.Select(date => DateTime.ParseExact(date, "M/d/yyyy", null)).Distinct().OrderByDescending(d => d).ToList();
        int streak = 1;
        for (int i = 1; i < streakDates.Count; i++)
        {
            if ((streakDates[i - 1] - streakDates[i]).Days == 1)
            {
                streak++;
            }
            else
            {
                break;
            }
        }
        return streak;
    }
}