public class BreathingActivity : Activity
{
  public BreathingActivity(string name, string description, int duration)
    : base(name, description, duration)
  {
    
  }

  public void Run()
  {
    DisplayStartingMessage();

    Console.WriteLine("Get ready to start breathing...");

    int secondsElapsed = 0;
    while (secondsElapsed < duration)
    {
      Console.WriteLine("Breathe in...");
      ShowCountDown(3); // Countdown for 3 seconds

      Console.WriteLine("Breathe out...");
      ShowCountDown(3); // Countdown for 3 seconds

      secondsElapsed += 6; // Each breathing cycle takes 6 seconds (3 seconds for inhale + 3 seconds for exhale)
    }

    DisplayEndingMessage();
  }
}