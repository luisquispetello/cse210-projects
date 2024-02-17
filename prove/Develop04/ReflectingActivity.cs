public class ReflectingActivity : Activity
{
  private List<string> _prompts = new()
  {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
  };

  private List<string> _questions = new()
  {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
  };

  public ReflectingActivity()
    : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 10)
  {
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
    string question = GetRandomQuestion();
    Console.WriteLine($"Reflecting Question: {question}");
    Thread.Sleep(2000);
    
  }
}