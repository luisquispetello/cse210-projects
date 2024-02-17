
public class Activity
{
  private string _name;
  private string _description;
  private int _duration;

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
  }

  public void ShowSpinner(int seconds)
  {
    Console.Write("Loading ");

    for (int i = 0; i < seconds; i--)
    {
      Console.Write(".");
      Thread.Sleep(1000); 
    }

    Console.WriteLine();
  }

  public void ShowCountDown(int seconds)
  {
    for(int i = 0; i< seconds; i--)
    {
      Console.WriteLine($"Countdown: {i}");
      Thread.Sleep(1000);
    }
    
  }
}