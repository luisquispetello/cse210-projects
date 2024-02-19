using System.IO; 

public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = new List<Goal>();
    _score = 0;
  }


  public void Start()
  {

    Dictionary<string, Action> actions = new()
    {
      { "1", () => CreateGoal() },
      { "2", () => ListGoalNames() },
      { "3", () => SaveGoals() },
      { "4", () => LoadGoals() },
      { "5", () => RecordEvent() },
      { "6", () => Environment.Exit(0) }
    };

    DisplayPlayerInfo();

    while (true)
    {
      Console.WriteLine("Menu Options:");
      Console.WriteLine("1. Create new goal");
      Console.WriteLine("2. List goals");
      Console.WriteLine("3. Save goals");
      Console.WriteLine("4. Load goals");
      Console.WriteLine("5. Record event");
      Console.WriteLine("6. Quit");

      Console.Write("Select a choice from the menu: ");
      string choice = Console.ReadLine();
      
      if (actions.ContainsKey(choice))
      {
        actions[choice].Invoke();
      }
      else
      {
        Console.WriteLine("Invalid choice. Please choose a number between 1 and 6.");
      }
    }
  }


  public void DisplayPlayerInfo()
  {
    Console.WriteLine($"You have {_score} points.");
  }


  public void ListGoalNames()
  {
    if(_goals.Count == 0)
    {
      Console.WriteLine("You do not have goals yet");
      return;
    }

    Console.WriteLine("The goals are: ");
    for(int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{_goals[i]}");
    }
  }
  

  public void ListGoalDetails()
  {
    Console.Clear();
    Console.WriteLine("List of Goals:");
    foreach (Goal goal in _goals)
    {
      Console.WriteLine(goal.GetDetailsString());
    }
    Console.WriteLine("");
  }


  public void CreateGoal()
  {  
    Console.WriteLine("Enter goal details:");
    Console.Write("Name of your goal: ");
    string name = Console.ReadLine();
    Console.Write("Short description: ");
    string description = Console.ReadLine();
    Console.Write("Points associated with this goal: ");
    int points = int.Parse(Console.ReadLine());
    Console.WriteLine("Type: ");
    Console.WriteLine("1. Simple");
    Console.WriteLine("2. Eternal");
    Console.WriteLine("3. Checklist");
    string type = Console.ReadLine();
    int target = 0;
    int bonus = 0;

    if(type == "3")
    {
      Console.Write("Target: ");
      target = int.Parse(Console.ReadLine());
      Console.Write("Bonus: ");
      bonus = int.Parse(Console.ReadLine());
    }

    Dictionary<string, Object> goals = new()
    {
      { "1", new SimpleGoal(name, description, points) },
      { "2", new EternalGoal(name, description, points) },
      { "3", new ChecklistGoal(name, description, points, target, bonus) }
    };

    if (goals.ContainsKey(type))
    {
      _goals.Add((Goal)goals[type]);
      Console.Clear();
      Console.WriteLine("Goal created!");
    }
    else
    {
      Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
    }
  }


  public void RecordEvent()
  {
    ListGoalNames();
    Console.WriteLine("Which goal did you accomplish? Enter goal number: ");
    int index = int.Parse(Console.ReadLine());

    if (index >= 0 && index < _goals.Count)
    {
      _goals[index].RecordEvent();
      _score += _goals[index].IsComplete() ? _goals[index].GetPoints() : 0;
      Console.WriteLine("Event recorded successfully.");
    }
    else
    {
      Console.WriteLine("Invalid goal number.");
    }
  }


  public void SaveGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string fileName = Console.ReadLine(); 

    using (StreamWriter outputFile = new(fileName))
    {
      foreach (Goal goal in _goals)
      {
        outputFile.WriteLine(goal.GetStringRepresentation());
      }
    }
    Console.Clear();
    Console.WriteLine("Goals saved successfully.");
  }


  public void LoadGoals()
  {
    Console.Write("What is the filename for the file goal: ");
    string filename = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      string[] parts = line.Split("|");

      string name = parts[0];
      string description = parts[1];
      int points = int.Parse(parts[2]);
      // For ChecklistGoal
      int target = parts.Length > 4 ? int.Parse(parts[4]) : 0;
      int bonus = parts.Length > 5 ? int.Parse(parts[5]) : 0;

      Goal goal;
      if (parts.Length == 3)
      {
        goal = new SimpleGoal(name, description, points);
      }
      else if (parts.Length == 6)
      {
        goal = new ChecklistGoal(name, description, points, target, bonus);
      }
      else
      {
        goal = new EternalGoal(name, description, points);
      }

      _goals.Add(goal);
    }

    Console.Clear();
    Console.WriteLine("Goals loaded successfully.");
  }
}