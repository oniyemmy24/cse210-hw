using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    
    public void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your Response: ");
        string response = Console.ReadLine();
        _entries.Add(new Entry(prompt, response));
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.Display());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine(entry.Serialize());
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                var entry = Entry.Deserialize(line);
                if (entry != null)
                {
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
