class Journal
{
  public List<Entry> _entries = new();

  public void AddEntry(Entry newEntry)
  {
    PromptGenerator generator = new();
    string prompt = generator.GetRandomPrompt();

    Console.WriteLine($"Prompt: {prompt}");
  }
  public void DisplayAll()
  {

  }
  public void SaveToFile(string file)
  {

  }
  public void LoadFromFile(string file)
  {

  }
}