using System;
using System.Collections.Generic;

public class WorkoutManager
{
  private Dictionary<int, Action> _menuOptions;
  private User _user;

  public WorkoutManager()
  {
    _menuOptions = new Dictionary<int, Action>
    {
      { 1, CreateWorkoutPlan },
      { 2, RecordWorkout },
      { 3, CalculateStatistics },
      { 4, SaveWorkout },
      { 5, Exit }
    };
  }

  public void Start()
  {
    Console.WriteLine("Are you a new user? (yes/no)");
    string newUserChoice = Console.ReadLine().ToLower();

    if (newUserChoice == "yes")
    {
      CreateUserAccount();
    }
    else if (newUserChoice == "no")
    {
      LoadUserData();
    }
    else
    {
      Console.WriteLine("Invalid choice. Please enter 'yes' or 'no'.");
      Start();
    }

    DisplayMenu();
  }

  private void CreateUserAccount()
  {
    Console.WriteLine("Creating a new user account...");
  }

  private void LoadUserData()
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

  private void DisplayMenu()
  {
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Create Workout Plan");
    Console.WriteLine("2. Record Workout");
    Console.WriteLine("3. Calculate Statistics");
    Console.WriteLine("4. Save Workout");
    Console.WriteLine("5. Exit");

    Console.Write("Select an option: ");
    int choice = int.Parse(Console.ReadLine());

    if (_menuOptions.ContainsKey(choice))
    {
      _menuOptions[choice].Invoke();
    }
    else
    {
      Console.WriteLine("Invalid choice. Please select a valid option.");
      DisplayMenu();
    }
  }

  private void CreateWorkoutPlan()
  {
    Console.WriteLine("Creating a workout plan...");
  }

  private void RecordWorkout()
  {
    Console.WriteLine("Recording a workout...");
  }

  private void CalculateStatistics()
  {
    Console.WriteLine("Calculating statistics...");
  }

  private void SaveWorkout()
  {
    Console.Write("What is the filename for the goal file? ");
    string fileName = Console.ReadLine();

    using (StreamWriter outputFile = new(fileName))
    {
      foreach (WorkoutLog workoutLog in workoutLogs)
      {
        outputFile.WriteLine(workoutLog);
      }
    }
    Console.Clear();
    Console.WriteLine("Goals saved successfully.");
  }

  private void Exit()
  {
    Console.WriteLine("Exiting program...");
    Environment.Exit(0);
  }
}