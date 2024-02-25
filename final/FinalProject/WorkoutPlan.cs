public class WorkoutPlan
{
  private string _name;
  private List<Exercise> _exercises;
  private int _duration;

  public WorkoutPlan(string name, List<Exercise> exercises, int duration)
  {
    _name = name;
    _exercises = exercises;
    _duration = duration;
  }

  public string GetName()
  {
    return _name;
  }
  
  public int GetDuration()
  {
    return _duration;
  }

  public int GetTotalDuration()
  {
    int totalDuration = 0;
    foreach (Exercise exercise in _exercises)
    {
      totalDuration += exercise is CardioExercise ? ((CardioExercise)exercise).DurationInMinutes : 0;
    }
    return totalDuration;
  }

  public double GetTotalCalories()
  {
    double totalCalories = 0;
    foreach (Exercise exercise in _exercises)
    {
      totalCalories += exercise.CalculateCaloriesBurned();
    }
    return totalCalories;
  }

  public void DisplayWorkoutPlanDetails()
  {
    int index = -1;
    Console.WriteLine($"WORKOUT NAME: {_name}");
    foreach (Exercise exercise in _exercises)
    {
      index++;
      Console.WriteLine($"Exercise {index} Details:");
      Console.WriteLine($"{exercise.DisplayExerciseDetails}");
    }
  }
}
