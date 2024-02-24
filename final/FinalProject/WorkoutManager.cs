using System;
using System.Collections.Generic;

public class WorkoutManager
{
  private User _user;
  private List<WorkoutPlan> _workoutsPlan;

  public WorkoutManager()
  {
  }

  public void Start()
  {

    Console.WriteLine("Are you a new user? (yes/no)");
    string choice = Console.ReadLine().ToLower();

    if (choice == "yes")
    {
      CreateUserAccount();
    }
    else if (choice == "no")
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


  private void DisplayMenu()
  {
    Dictionary<string, Action> menuOptions = new()
    {
      { "1", CreateWorkoutPlan },
      { "2", RecordWorkout },
      { "3", CalculateStatistics },
      { "4", SaveWorkout },
      { "5", Exit }
    };

    Console.WriteLine("Menu Options:");
    Console.WriteLine("1. Create Workout Plan");
    Console.WriteLine("2. Record Workout");
    Console.WriteLine("3. Calculate Statistics");
    Console.WriteLine("4. Save Workout");
    Console.WriteLine("5. Exit");

    Console.Write("Select an option: ");
    string choice = Console.ReadLine();

    if (menuOptions.ContainsKey(choice))
    {
      menuOptions[choice].Invoke();
    }
    else
    {
      Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
      DisplayMenu();
    }
  }


  private void CreateUserAccount()
  {
    Console.WriteLine("Creating a new user account...");

    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine());

    Console.Write("Enter your gender: ");
    string gender = Console.ReadLine();

    Console.Write("Enter your weight in Kg: ");
    int weight = int.Parse(Console.ReadLine());

    // Creamos una nueva instancia de User con los datos proporcionados
    _user = new User(name, age, gender, weight);

    Console.WriteLine("User account created successfully!");
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

  private void CreateWorkoutPlan()
  {
    List<Exercise> exercises = new();
    bool addingExercises = true;

    Dictionary<string, Action> exerciseOptions = new()
    {
      { "1", () =>
        {
          Console.Write("Name of cardio exercise: ");
          string cardioName = Console.ReadLine();
          Console.Write("Duration (minutes): ");
          int cardioDuration = int.Parse(Console.ReadLine());

          CardioExercise cardioExercise = new(cardioName, cardioDuration);
          exercises.Add(cardioExercise);
        }
      },
      { "2", () =>
        {
          Console.Write("Name of strength exercise: ");
          string strengthName = Console.ReadLine();
          Console.Write("Repetitions: ");
          int repetitions = int.Parse(Console.ReadLine());
          Console.Write("Sets: ");
          int sets = int.Parse(Console.ReadLine());
          Console.Write("Weight lifted (kg): ");
          int weightLifted = int.Parse(Console.ReadLine());

          StrengthExercise strengthExercise = new(strengthName, repetitions, sets, weightLifted);
          exercises.Add(strengthExercise);
        }
      },
      { "3", () => addingExercises = false }
    };

    Console.WriteLine("Enter workout plan details:");
    Console.Write("Name of your workout plan: ");
    string name = Console.ReadLine();
    Console.Write("How many days a week are you going to train?: ");
    int duration = int.Parse(Console.ReadLine());
    Console.WriteLine("Now you will add exercises for your workuot. Select 3 when you have finished adding exercises.");

    while (addingExercises)
    {
      Console.WriteLine("Select exercise type:");
      Console.WriteLine("1. Cardio");
      Console.WriteLine("2. Strength");
      Console.WriteLine("3. Done adding exercises");

      string exerciseType = Console.ReadLine();

      if (exerciseOptions.ContainsKey(exerciseType))
      {
        exerciseOptions[exerciseType].Invoke();
      }
      else
      {
        Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
      }
    }

    WorkoutPlan workoutPlan = new(name, exercises, duration);
    _workoutsPlan.Add(workoutPlan);
    Console.WriteLine("Workout plan created!");

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
