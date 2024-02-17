public class ReflectingActivity : Activity
{
  private List<string> _prompts;
  private List<string> _questions;

  public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions )
    : base(name, description, duration)
  {
    _prompts = prompts;
    _questions = questions;
  }

  public void Run()
  {
    DisplayStartingMessage();
    Thread.Sleep(3000);
    DisplayPrompt();
    DisplayQuestions();
    DisplayEndingMessage();
  }

  public string GetRandomPrompt()
  {
    Random random = new();
    return _prompts[random.Next(_prompts.Count)];
  }

  public string GetRandomQuestion()
  {
    Random random = new();
    return _questions[random.Next(_questions.Count)];
  }

  public void DisplayPrompt()
  {
    string prompt = GetRandomPrompt();
    Console.WriteLine($"Reflecting Prompt: {prompt}");
    Thread.Sleep(2000);
  }

  public void DisplayQuestions()
  {
    
  }
}