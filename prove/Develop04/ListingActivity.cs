public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts;

  public ListingActivity(string name, string description, int duration, List<string> prompts)
    : base(name, description, duration)
  {
    _prompts = prompts;
  }

  public void Run()
  {
    DisplayStartingMessage();
    Thread.Sleep(3000);
    ShowSpinner(3); // Pause for 3 seconds with a spinner animation
  }

  public void GetRandomPrompt()
  {
    Random random = new();

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