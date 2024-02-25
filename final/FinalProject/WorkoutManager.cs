using System;
using System.IO;

public class WorkoutManager
{
  private User _user;
  private List<WorkoutPlan> _workoutPlans;
  private WorkoutLog _workoutLog;


  public WorkoutManager()
  {
    _workoutPlans = new List<WorkoutPlan>();
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
    Console.WriteLine("Loading user data...");
    Console.Write("Enter the filename for the user data file: ");
    string filename = Console.ReadLine();


    string[] lines = File.ReadAllLines(filename);

    if (lines.Length != 4)
    {
      Console.WriteLine("Invalid data format in the file. Expected 4 lines for user data.");
      return;
    }

    string name = lines[0];
    int age = int.Parse(lines[1]);
    string gender = lines[2];
    int weight = int.Parse(lines[3]);

    _user = new User(name, age, gender, weight);

    Console.WriteLine("User data loaded successfully.");
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
    _workoutPlans.Add(workoutPlan);
    Console.WriteLine("Workout plan created!");
    DisplayMenu();
  }


  private void RecordWorkout()
  {
    Console.WriteLine("Available workout plans:");
    for (int i = 0; i < _workoutPlans.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {_workoutPlans[i].GetName}");
    }

    Console.Write("Select a workout plan to record: ");
    int choice = int.Parse(Console.ReadLine());

    if (choice >= 1 && choice <= _workoutPlans.Count)
    {
      WorkoutPlan selectedWorkoutPlan = _workoutPlans[choice - 1];
      _workoutLog.AddCompletedWorkout(selectedWorkoutPlan);
      Console.WriteLine("Workout recorded successfully.");
      DisplayMenu();

    }
    else
    {
      Console.WriteLine("Invalid choice.");
    }
  }


  private void CalculateStatistics()
  {
    Console.WriteLine("Calculating statistics...");
  }


  private void SaveWorkout()
  {
    Console.WriteLine("Saving workout data...");

    Console.Write("Enter the filename to save workout data: ");
    string fileName = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      foreach (WorkoutPlan workoutPlan in _workoutLog.GetCompletedWorkouts())
      {
        outputFile.WriteLine(workoutPlan.ToString());
      }
    }

    Console.WriteLine("Workout data saved successfully.");
    DisplayMenu();
  }


  private void Exit()
  {
    Console.WriteLine("Exiting program...");
    Environment.Exit(0);
  }
}
