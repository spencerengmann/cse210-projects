using System;

class Journal
{
    private List<Entry> entries;
    private List<string> prompts;

    public List<Entry> Entries
    {
        get { return entries; }
        set { entries = value; }
    }

    public List<string> Prompts
    {
        get { return prompts; }
        set { prompts = value; }
    }

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What are you most grateful for today?"
        };
    }

    public void WriteEntry()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        Console.Write(prompt + " ");
        string response = Console.ReadLine();
        Entry entry = new Entry(prompt, response);
        entries.Add(entry);
        Console.WriteLine($"Entry added successfully! Date");
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            string dateTimeString = $"{entry.Date:d} {DateTime.Now:T}";
            Console.WriteLine($"{dateTimeString}: {entry.Prompt} - {entry.Response}");
        }
    }

    public void SaveJournal()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in Entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved to file!");

    }

    public void LoadJournal()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        Entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string response = parts[2];
                Entry entry = new Entry(prompt, response);
                entry.Date = date;
                Entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded!");
    }
}