public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts = new List<string>
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
  };

  public ListingActivity()
    : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 10)
  {
  }

  public void Run()
  {
    DisplayStartingMessage();
    Thread.Sleep(3000);
    ShowSpinner(3); // Pause for 3 seconds with a spinner animation
    DisplayEndingMessage();
  }

  public string GetRandomPrompt()
  {
    Random random = new();
    return _prompts[random.Next(_prompts.Count)];
  }

  public List<string> GetListFromUser()
  {
    List<string> itemsList = new List<string>();
    Console.WriteLine("Enter personal strenghts (one per line, type 'done' when finished):");

    string input;

    do
    {
      input = Console.ReadLine();
      if (input.ToLower() != "done")
        itemsList.Add(input);
    } while (input.ToLower() != "done");

    return itemsList;
  }
}