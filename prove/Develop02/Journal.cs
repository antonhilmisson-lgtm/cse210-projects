using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private string[] prompts = {
        "What made you smile today?",
        "What is one thing you learned today?",
        "What challenged you today?",
        "Describe a moment you are grateful for today."
    };

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }

        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public string PromptMaker()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        return prompts[index];
    }
}
