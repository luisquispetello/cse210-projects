class PromptGenerator
{
  public List<string> _prompts = new();

  public string GetRandomPrompt()
  {
    Random random = new();    
    return _prompts[random.Next(_prompts.Count)];
  }
}