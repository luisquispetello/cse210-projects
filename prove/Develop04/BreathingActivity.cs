public class BreathingActivity : Activity
{
  public BreathingActivity()
    : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 10)
  {
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