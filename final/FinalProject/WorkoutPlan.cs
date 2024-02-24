public class WorkoutPlan
{
  private List<Exercise> _exercises;
  private int _duration;

  public WorkoutPlan(List<Exercise> exercises)
  {
    _exercises = exercises;
    _duration = GetTotalDuration();
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
}
