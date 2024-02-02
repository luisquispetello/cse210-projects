
using System;

class Program
{
  static void Main(string[] args)
  {
    Journal journal = new();
    PromptGenerator promptGenerator = new();


    // Instead of if statements I choose a Dictionary because is more readable
    Dictionary<string, Action> actions = new()
    {
      { "1", () => journal.AddEntry() },
      { "2", () => journal.DisplayAll() },
      { "3", () => journal.SaveToFile("journal.csv") },
      { "4", () => journal.LoadFromFile("journal.csv") },
      { "5", () => Environment.Exit(0) }
    };


    while (true)
    {
      Console.WriteLine("Please select one of the folowing choices:");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Load");
      Console.WriteLine("4. Save");
      Console.WriteLine("5. Quit");

      Console.WriteLine("What would you like to do?");
      string userChoice = Console.ReadLine();


      if (actions.ContainsKey(userChoice))
      {
        actions[userChoice].Invoke();
      }
      else
      {
        Console.WriteLine("Invalid option. Please try again.");
      }
    }

  }
}