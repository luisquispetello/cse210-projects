public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts;

  public ListingActivity(string name, string description, int duration)
    : base(name, description, duration)
  {

  }

  public void Run()
  {
    DisplayStartingMessage();
    Thread.Sleep(3000);
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