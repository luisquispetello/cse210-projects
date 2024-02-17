using System;

class Program
{
  static void Main(string[] args)
  {
    List<string> prompts = new()
    {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless."
    };

    List<string> questions = new()
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

    List<string> description = new()
    {
      "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
      "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
      "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    };


    BreathingActivity breathingActivity = new("Breathing", description[0], 10);
    ReflectingActivity reflectingActivity = new("Reflecting", description[1], 15, prompts, questions);
    ListingActivity listingActivity = new("Listing", description[2], 20, prompts);


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