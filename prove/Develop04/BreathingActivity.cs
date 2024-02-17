public class BreathingActivity : Activity
{
  public BreathingActivity(string name, string description, int duration)
    : base(name, description, duration)
  {
    _duration = duration;
  }

  public void Run()
  {
    DisplayStartingMessage();

    Console.WriteLine("Get ready to start breathing...");

    int remainingTime = _duration;
    while (remainingTime > 0)
    {
      Console.WriteLine("Breathe in...");
      ShowCountDown(3); 

      Console.WriteLine("Breathe out...");
      ShowCountDown(3); 

      remainingTime -= 6; 
    }

    DisplayEndingMessage();
  }
}