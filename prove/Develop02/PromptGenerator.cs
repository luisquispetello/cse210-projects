
public class PromptGenerator
{
  public List<string> _prompts = new()
  {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What was the most important think I made today?",
    "If you could change something of today, what it could be?",
    "Count the blessings you have received today."
  };

  public string GetRandomPrompt()
  {
    Random random = new();
    return _prompts[random.Next(_prompts.Count)];
  }
}