
public class Activity
{
  private string _name;
  private string _description;
  protected int _duration;

  public Activity(string name, string description, int duration)
  {
    _name = name;
    _description = description;
    _duration = duration;
  }

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Starting {_name} activity:");
    Console.WriteLine(_description);
    Console.WriteLine($"Duration: {_duration} seconds.");
    Console.WriteLine("Prepare to begin...");
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine($"GREAT! You have completed the {_name} activity.");
    Console.WriteLine($"Total duration: {_duration} seconds");

  }

  public void ShowSpinner(int seconds)
  {
    for (int i = 0; i < seconds; i++)
    {
      Console.Write("/");
      Thread.Sleep(100); // Pause for 0.1 second
      Console.Write("\b");
      Console.Write("-");
      Thread.Sleep(100); // Pause for 0.1 second
      Console.Write("\b");
      Console.Write("\\");
      Thread.Sleep(100); // Pause for 0.1 second
      Console.Write("\b");
      Console.Write("|");
      Thread.Sleep(100); // Pause for 0.1 second
      Console.Write("\b");
    }
  }

  public void ShowCountDown(int seconds)
  {
    for(int i = 0; i< seconds; i--)
    {
      Console.WriteLine($"Time remaining: {i} seconds");
      Thread.Sleep(1000);
    }
    
  }
}