using System.IO;

public class Journal
{
  public List<Entry> _entries = new();

  public void AddEntry()
  {
    PromptGenerator promptGenerator = new();
    string prompt = promptGenerator.GetRandomPrompt();

    Console.WriteLine($"Prompt: {prompt}");
    Console.WriteLine($"Write your response: ");

    string response = Console.ReadLine();

    Entry newEntry = new()
    {
      _date = DateTime.Now.ToString("dd/MM/yyyy"),
      _promptText = prompt,
      _entryText = response
    };

    _entries.Add(newEntry);
    Console.WriteLine("Entry added successfully");
  }

  public void DisplayAll()
  {
    if (_entries.Count == 0)
    {
      Console.WriteLine("Journal is empty");
    }

    foreach (Entry entry in _entries)
    {
      entry.Display();
    }
  }

  public void SaveToFile(string fileName)
  {
    using (StreamWriter outputFile = new(fileName))
    {
      outputFile.WriteLine("Date,Prompt,Entry");

      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
      }
    }

    Console.WriteLine("Journal saved successfully.");
  }

  public void LoadFromFile(string fileName)
  {
    List<Entry> loadedEntries = new();

    string[] lines = File.ReadAllLines(fileName);

    foreach (string line in lines)
    {
      string[] parts = line.Split(',');
      if (parts.Length == 3)
      {
        Entry entry = new()
        {
          _date = parts[0],
          _promptText = parts[1],
          _entryText = parts[2]
        };
        loadedEntries.Add(entry);
      }
    }

    _entries = loadedEntries;
    Console.WriteLine("Journal loaded successfully.");
  }
}