using System;

class Program
{
  static void Main(string[] args)
  {

    BreathingActivity breathingActivity = new();
    ReflectingActivity reflectingActivity = new();
    ListingActivity listingActivity = new();


    Dictionary<string, Action> actions = new()
    {
      { "1", () => breathingActivity.Run() },
      { "2", () => reflectingActivity.Run() },
      { "3", () => listingActivity.Run() },
      { "4", () => Environment.Exit(0) }
    };


    while (true)
    {
      Console.WriteLine("Menu Options:");
      Console.WriteLine("1. Start Breathing Activity");
      Console.WriteLine("2. Start Reflection Activity");
      Console.WriteLine("3. Start Listing Activity");
      Console.WriteLine("4. Quit");

      string input = Console.ReadLine();
      if (actions.ContainsKey(input))
      {
        actions[input].Invoke();
      }
      else
      {
        Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
      }
    }
  }
}